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
        private Instrument[] _watchedInstruments;
        private DateTime _lastUpdate;

        public FrmMain()
        {
            InitializeComponent();
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            await Login();
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
                _watchedInstruments = Argentina.Data.AllInstruments.Where(ShouldWatch).ToArray();

                foreach (var item in Argentina.Data.AllInstruments.OrderBy(x => x.SymbolWithoutPrefix()))
                {
                    cmbInstruments.Items.Add(item);
                }

                var frmArbitrationAnalyzer = new FrmArbitrationAnalyzer();
                //frmArbitrationAnalyzer.MdiParent = this;
                frmArbitrationAnalyzer.Show();

                Argentina.Data.OnMarketData += Data_OnMarketData;

                backgroundTasks.Add(Argentina.Data.WatchWithWebSocket(_watchedInstruments));
            }
        }

        private void Data_OnMarketData(Instrument instrument, Entries data)
        {
            try
            {
                var dif = DateTime.Now - _lastUpdate;

                if (dif.TotalSeconds > 1)
                {
                    _lastUpdate = DateTime.Now;
                    this.Invoke(new Action(() => this.Text = $"Arbitrador - Last WebSocket Message: {_lastUpdate:HH:mm:ss} {dif.TotalSeconds:#0} seconds ago"));
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MarketDataClosing(object sender, FormClosingEventArgs e)
        {

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
            //frmHistoric.MdiParent = this;
            frmHistoric.Show();
        }

        private void buscadorDeArbitrajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmArbitrationAnalyzer = new FrmArbitrationAnalyzer();
            //frmArbitrationAnalyzer.MdiParent = this;
            frmArbitrationAnalyzer.Show();

        }

        private void cmbInstruments_SelectedIndexChanged(object sender, EventArgs e)
        {
            var instrument = cmbInstruments.SelectedItem as Instrument;
            var frmMarketData = new FrmMarketData();
            frmMarketData.SetInstrument(instrument);
            //frmMarketData.MdiParent = this;
            frmMarketData.Show();
        }

        private void dolarPricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDolarPrices = new FrmDolarPrices();
            //frmDolarPrices.MdiParent = this;
            frmDolarPrices.Show();
        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Argentina.Data.RefreshMarketData(_watchedInstruments).ToArray();
        }
    }
}
