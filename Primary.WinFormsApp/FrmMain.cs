using Primary.Data;
using Primary.WebSockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmMain : Form
    {
        private List<string> watchList;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private async Task Login()
        {
            var login = new FrmLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                var success = await Argentina.Data.Api.Login(login.UserName, login.Password);

                if (success == false)
                {
                    MessageBox.Show("Login Failed", "Login Failed", MessageBoxButtons.OK);
                    return;
                }

                Properties.Settings.Default.UserName = login.UserName;
                Properties.Settings.Default.Save();

                await Argentina.Data.Init();

                //InitWatchList();
                var watchedInstruments = Argentina.Data.AllInstruments.Where(ShouldWatch).ToArray();

                foreach (var watchInstrument in watchedInstruments)
                {
                    var frmMarketData = new FrmMarketData();
                    frmMarketData.SetInstrument(watchInstrument.Symbol);
                    Argentina.Data.OnMarketData += frmMarketData.OnMarketData;
                    frmMarketData.MdiParent = this;
                    frmMarketData.Show();
                    frmMarketData.FormClosing += MarketDataClosing;
                }

                await Argentina.Data.WatchIntruments(watchedInstruments);
            }
        }

        private void MarketDataClosing(object sender, FormClosingEventArgs e)
        {
            var frmMarketData = (FrmMarketData)sender;
            Argentina.Data.OnMarketData -= frmMarketData.OnMarketData;
        }

        private void InitWatchList()
        {
            //var bonds = new[] { "AL29", "AL30", "AL35", "AE38", "AL41", "GD29", "GD30", "GD35", "GD38", "GD41", "GD46" };
            var bonds = new[] { "AL30"};

            var bondsD = bonds.Select(x => x + "D");
            var bondsC = bonds.Select(x => x + "C");
            var allBonds = bonds.Concat(bondsD).Concat(bondsC);

            this.watchList = new List<string>();
            foreach (var item in allBonds)
            {
                watchList.AddRange(ToMervalSymbol(item));
            }

        }

        private bool ShouldWatch(Instrument instrument)
        {
            return Properties.Settings.Default.WatchedSymbols.Contains(instrument.Symbol);
        }

        private static string[] ToMervalSymbol(string ticker)
        {
            return new[] { 
                $"MERV - XMEV - {ticker} - 48hs", 
                $"MERV - XMEV - {ticker} - 24hs", 
                $"MERV - XMEV - {ticker} - CI" 
            };
        }

        private async void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Login();
        }

        private void historicDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmHistoric = new FrmHistoricData();
            frmHistoric.MdiParent = this;
            frmHistoric.Show();
        }
    }
}
