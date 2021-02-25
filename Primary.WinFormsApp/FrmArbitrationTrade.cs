using System;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmArbitrationTrade : Form
    {
        private DolarArbitrationTrade _trade;
        private decimal _ownedVentaTotal;
        private decimal _ownedVentaComision;
        private decimal _arbitrationVentaTotal;
        private decimal _arbtrationVentaComision;

        public decimal Comision => numComision.Value / 100;

        public FrmArbitrationTrade()
        {
            InitializeComponent();
        }

        private void FrmArbitrationTrade_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblOwnedLast.Text = _trade.Owned.Last.ToCurrency();
            lblArbitrationDiff.Text = (_trade.Arbitration.Last / _trade.Owned.Last - 1m).ToString("P");
            lblArbitrationLast.Text = _trade.Arbitration.Last.ToCurrency();

            lblOwnedVentaLast.Text = _trade.Owned.Dolar.Data.Last.Price.Value.ToUSD();
            if (!OwnedVentaChanged())
            {
                numOwnedVentaPrice.Value = _trade.Owned.Dolar.Data.GetTopBidPrice();
            }
            lblBookOwnedVentaBid.Text = _trade.Owned.Dolar.Data.ToReadableBids();
            lblBookOwnedVentaOffer.Text = _trade.Owned.Dolar.Data.ToReadableOffers();

            lblArbitrationCompraLast.Text = _trade.Arbitration.Dolar.Data.Last.Price.Value.ToUSD();
            if (!ArbitrationCompraChanged())
            {
                numArbitrationCompraPrice.Value = _trade.Arbitration.Dolar.Data.GetTopOfferPrice();
            }
            lblBookArbitrationCompraBid.Text = _trade.Arbitration.Dolar.Data.ToReadableBids();
            lblBookArbitrationCompraOffer.Text = _trade.Arbitration.Dolar.Data.ToReadableOffers();

            lblArbitrationVentaLast.Text = _trade.Arbitration.Pesos.Data.Last.Price.Value.ToCurrency();
            if (!ArbitrationVentaChanged())
            {
                numArbitrationVentaPrice.Value = _trade.Arbitration.Pesos.Data.GetTopBidPrice();
            }
            lblBookArbitrationVentaBid.Text = _trade.Arbitration.Pesos.Data.ToReadableBids();
            lblBookArbitrationVentaOffer.Text = _trade.Arbitration.Pesos.Data.ToReadableOffers();

            lblOwnedCompraLast.Text = _trade.Owned.Pesos.Data.Last.Price.Value.ToCurrency();
            if (!OwnedCompraChanged())
            {
                numOwnedCompraPrice.Value = _trade.Owned.Pesos.Data.GetTopOfferPrice();
            }
            lblBookOwnedCompraBid.Text = _trade.Owned.Pesos.Data.ToReadableBids();
            lblBookOwnedCompraOffer.Text = _trade.Owned.Pesos.Data.ToReadableOffers();

        }

        internal void Init(DolarArbitrationTrade trade)
        {
            _trade = trade;

            grpOwnedVenta.Text += " - " + _trade.Owned.Dolar.Instrument.SymbolWithoutPrefix();
            grpArbitrationCompra.Text += " - " + _trade.Arbitration.Dolar.Instrument.SymbolWithoutPrefix();
            grpArbitrationVenta.Text += " - " + _trade.Arbitration.Pesos.Instrument.SymbolWithoutPrefix();
            grpOwnedCompra.Text += " - " + _trade.Owned.Pesos.Instrument.SymbolWithoutPrefix();

            numOwnedVentaSize.Value = 1000; // TODO: Get Max Size
            numOwnedVentaPrice.Value = _trade.Owned.Dolar.Data.Last.Price.Value;
            numArbitrationCompraPrice.Value = _trade.Arbitration.Dolar.Data.Last.Price.Value;
            numArbitrationVentaPrice.Value = _trade.Arbitration.Pesos.Data.Last.Price.Value;
            numOwnedCompraPrice.Value = _trade.Owned.Pesos.Data.Last.Price.Value;

        }

        public void CalculateOwnedVenta()
        {
            _ownedVentaTotal = numOwnedVentaSize.Value * numOwnedVentaPrice.Value / 100m;
            _ownedVentaComision = _ownedVentaTotal * Comision;
            numOwnedCompraSize.Value = numOwnedVentaSize.Value;

            lblOwnedVentaTotal.Text = _ownedVentaTotal.ToUSD();
            lblOwnedComision.Text = _ownedVentaComision.ToUSD();

            CalculateArbitrationCompraSize();
        }

        public void CalculateArbitrationCompraSize()
        {
            if (numArbitrationCompraPrice.Value > 0)
            {
                numArbitrationCompraSize.Value = (_ownedVentaTotal - _ownedVentaComision) / numArbitrationCompraPrice.Value * 100m;
            }
            CalculateArbitrationCompraTotal();
            CalculateArbitrationVentaSize();
        }

        public void CalculateArbitrationCompraTotal()
        {
            lblArbitrationCompraTotal.Text = (numArbitrationCompraPrice.Value * numArbitrationCompraSize.Value / 100m).ToUSD();
        }

        public void CalculateArbitrationVentaSize()
        {
            numArbitrationVentaSize.Value = numArbitrationCompraSize.Value;

            CalculateArbitrationVentaTotal();
        }

        public void CalculateArbitrationVentaTotal()
        {
            _arbitrationVentaTotal = numArbitrationVentaSize.Value * numArbitrationVentaPrice.Value / 100m;
            _arbtrationVentaComision = _arbitrationVentaTotal * Comision;

            lblArbitrationVentaTotal.Text = _arbitrationVentaTotal.ToCurrency();
            lblArbitrationComision.Text = _arbtrationVentaComision.ToCurrency();

            CalculateOwnedCompraTotalAndProfit();
        }

        public void CalculateOwnedCompraTotalAndProfit()
        {
            var ownedCompraTotal = numOwnedCompraSize.Value * numOwnedCompraPrice.Value / 100m;
            lblOwnedCompraTotal.Text = ownedCompraTotal.ToCurrency();
            var profit = _arbitrationVentaTotal - _arbtrationVentaComision - ownedCompraTotal;
            var profitPercentage = 0m;
            if (ownedCompraTotal != 0m)
            {
                profitPercentage = profit / ownedCompraTotal;
            }
            lblProfit.Text = "Profit: " + profit.ToCurrency() + " / " + (profitPercentage).ToString("P");
        }

        private void numOwnedVentaSize_ValueChanged(object sender, EventArgs e)
        {
            CalculateOwnedVenta();
        }

        private void numOwnedVentaPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateOwnedVenta();

        }

        private void numArbitrationCompraSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numArbitrationCompraPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateArbitrationCompraSize();
        }

        private void numArbitrationVentaSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numArbitrationVentaPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateArbitrationVentaSize();
        }

        private void numOwnedCompraSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numOwnedCompraPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateOwnedCompraTotalAndProfit();
        }

        public bool OwnedVentaChanged()
        {
            return numOwnedVentaPrice.ForeColor == System.Drawing.SystemColors.WindowText;
        }

        private void numOwnedVentaPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            numOwnedVentaPrice.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        public bool ArbitrationCompraChanged()
        {
            return numArbitrationCompraPrice.ForeColor == System.Drawing.SystemColors.WindowText;
        }

        private void numArbitrationCompraPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            numArbitrationCompraPrice.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        public bool ArbitrationVentaChanged()
        {
            return numArbitrationVentaPrice.ForeColor == System.Drawing.SystemColors.WindowText;
        }

        private void numArbitrationVentaPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            numArbitrationVentaPrice.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        public bool OwnedCompraChanged()
        {
            return numOwnedCompraPrice.ForeColor == System.Drawing.SystemColors.WindowText;
        }
        private void numOwnedCompraPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            numOwnedCompraPrice.ForeColor = System.Drawing.SystemColors.WindowText;
        }
    }
}
