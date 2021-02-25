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
    public partial class FrmArbitrationTrade : Form
    {
        private DolarArbitrationTrade _trade;

        public FrmArbitrationTrade()
        {
            InitializeComponent();
        }

        private void FrmArbitrationTrade_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblOwnedLast.Text = _trade.Owned.Last.ToString("C2");
            lblArbitrationLast.Text = _trade.Arbitration.Last.ToString("C2");

            lblOwnedVentaLast.Text = _trade.Owned.Dolar.Data.Last.Price.Value.ToString("C2");
            lblBookOwnedVenta.Text = _trade.Owned.Dolar.Data.ToReadableBids();

            lblArbitrationCompraLast.Text = _trade.Arbitration.Dolar.Data.Last.Price.Value.ToString("C2");
            lblBookArbitrationCompra.Text = _trade.Arbitration.Dolar.Data.ToReadableOffers();

            lblArbitrationVentaLast.Text = _trade.Arbitration.Pesos.Data.Last.Price.Value.ToString("C2");
            lblBookArbitrationVenta.Text = _trade.Arbitration.Pesos.Data.ToReadableBids();

            lblOwnedCompraLast.Text = _trade.Owned.Pesos.Data.Last.Price.Value.ToString("C2");
            lblBookOwnedCompra.Text = _trade.Owned.Pesos.Data.ToReadableOffers();

        }

        internal void Init(DolarArbitrationTrade trade)
        {
            _trade = trade;

            grpOwnedVenta.Text += " - " + _trade.Owned.Dolar.Instrument.SymbolWithoutPrefix();
            grpArbitrationCompra.Text += " - " + _trade.Arbitration.Dolar.Instrument.SymbolWithoutPrefix();
            grpArbitrationVenta.Text += " - " + _trade.Arbitration.Pesos.Instrument.SymbolWithoutPrefix();
            grpOwnedCompra.Text += " - " + _trade.Owned.Pesos.Instrument.SymbolWithoutPrefix();
        }

        private void numOwnedVentaSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numOwnedVentaPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numArbitrationCompraSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numArbitrationCompraPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numArbitrationVentaSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numArbitrationVentaPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numOwnedCompraSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numOwnedCompraPrice_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
