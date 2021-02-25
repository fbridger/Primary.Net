using Primary.Data;
using Primary.WebSockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmMain : Form
    {
        private List<string> watchList;
        private List<Task> backgroundTasks = new List<Task>();

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
                Properties.Settings.Default.Password = login.Password;
                Properties.Settings.Default.Save();

                await Argentina.Data.Init();

                InitWatchList();
                var watchedInstruments = Argentina.Data.AllInstruments.Where(ShouldWatch).ToArray();

                /*
                foreach (var watchInstrument in watchedInstruments)
                {
                    var frmMarketData = new FrmMarketData();
                    frmMarketData.SetInstrument(watchInstrument);
                    Argentina.Data.OnMarketData += frmMarketData.OnMarketData;
                    frmMarketData.MdiParent = this;
                    frmMarketData.Show();
                    frmMarketData.FormClosing += MarketDataClosing;
                }
                

                var frmDolarArbitation = new FrmDolarArbitration();
                frmDolarArbitation.InitData();
                frmDolarArbitation.MdiParent = this;
                frmDolarArbitation.Show();
                Argentina.Data.OnMarketData += frmDolarArbitation.OnMarketData;
                frmDolarArbitation.FormClosing += MarketDataClosing;
                */

                var frmArbitrationBestTrades = new FrmArbitrationBestTrades();
                frmArbitrationBestTrades.MdiParent = this;
                frmArbitrationBestTrades.Show();

                backgroundTasks.AddRange(Argentina.Data.WatchWithRestApi(watchedInstruments));
            }
        }

        private void MarketDataClosing(object sender, FormClosingEventArgs e)
        {
            if(sender is FrmMarketData frmMarketData)
            {
                Argentina.Data.OnMarketData -= frmMarketData.OnMarketData;
            }
            else if (sender is FrmDolarArbitration frmDolarArbitration)
            {
                Argentina.Data.OnMarketData -= frmDolarArbitration.OnMarketData;
            }
        }

        private void InitWatchList()
        {
            //var bonds = new[] { "AL29", "AL30", "AL35", "AE38", "AL41", "GD29", "GD30", "GD35", "GD38", "GD41", "GD46" };
            var owned = Properties.Settings.Default.OwnedTickers.Cast<string>().ToList();
            var arbitration = Properties.Settings.Default.ArbitrationTickers.Cast<string>().ToList();

            var bonds = arbitration.Concat(owned).Distinct();

            this.watchList = new List<string>();
            foreach (var item in bonds)
            {
                watchList.AddRange(item.GetAllSymbols());
            }

        }

        private bool ShouldWatch(Instrument instrument)
        {
            if (watchList.Contains(instrument.Symbol))
            {
                return true;
            }
            
            return false;
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
