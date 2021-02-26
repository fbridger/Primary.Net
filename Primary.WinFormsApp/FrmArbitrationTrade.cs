using System;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmArbitrationTrade : Form
    {
        private DolarArbitrationTrade _trade;
        private decimal _ownedVentaImporte;
        private decimal _ownedVentaComision;
        private decimal _arbitrationVentaImporte;
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
            _ownedVentaImporte = numOwnedVentaSize.Value * numOwnedVentaPrice.Value / 100m;
            _ownedVentaComision = _ownedVentaImporte * Comision;
            numOwnedCompraSize.Value = numOwnedVentaSize.Value;

            lblOwnedVentaImporte.Text = "Importe: " + _ownedVentaImporte.ToUSD();
            lblOwnedComision.Text = "Comisión: " + _ownedVentaComision.ToUSD();
            lblOwnedVentaTotal.Text = "Total: " + (_ownedVentaImporte - _ownedVentaComision).ToUSD();

            CalculateArbitrationCompraSize();
        }

        public void CalculateArbitrationCompraSize()
        {
            if (numArbitrationCompraPrice.Value > 0)
            {
                numArbitrationCompraSize.Value = (_ownedVentaImporte - _ownedVentaComision) / numArbitrationCompraPrice.Value * 100m;
            }
            CalculateArbitrationCompraTotal();
            CalculateArbitrationVentaSize();
        }

        public void CalculateArbitrationCompraTotal()
        {
            lblArbitrationCompraImporte.Text = "Importe: " + (numArbitrationCompraPrice.Value * numArbitrationCompraSize.Value / 100m).ToUSD();
        }

        public void CalculateArbitrationVentaSize()
        {
            numArbitrationVentaSize.Value = numArbitrationCompraSize.Value;

            CalculateArbitrationVentaTotal();
        }

        public void CalculateArbitrationVentaTotal()
        {
            _arbitrationVentaImporte = numArbitrationVentaSize.Value * numArbitrationVentaPrice.Value / 100m;
            _arbtrationVentaComision = _arbitrationVentaImporte * Comision;

            lblArbitrationVentaImporte.Text = "Importe: " + _arbitrationVentaImporte.ToCurrency();
            lblArbitrationComision.Text = "Comisión: " + _arbtrationVentaComision.ToCurrency();
            lblArbitrationVentaTotal.Text = "Total: " + (_arbitrationVentaImporte - _arbtrationVentaComision).ToCurrency();

            CalculateOwnedCompraTotalAndProfit();
        }

        public void CalculateOwnedCompraTotalAndProfit()
        {
            var ownedCompraTotal = numOwnedCompraSize.Value * numOwnedCompraPrice.Value / 100m;
            lblOwnedCompraImporte.Text = "Importe: " + ownedCompraTotal.ToCurrency();

            var profit = _arbitrationVentaImporte - _arbtrationVentaComision - ownedCompraTotal;

            var dolarVenta = numOwnedVentaPrice.Value > 0 ? numOwnedCompraPrice.Value / numOwnedVentaPrice.Value : 0;
            var dolarCompra = numArbitrationCompraPrice.Value > 0 ? numArbitrationVentaPrice.Value / numArbitrationCompraPrice.Value : 0;
            var dolarDiff = dolarVenta > 0 ? dolarCompra / dolarVenta - 1 : 0;
            lblProfit.Text = "Profit: " + profit.ToCurrency() + Environment.NewLine + $"Dolar Venta: {dolarVenta:C2}     {dolarDiff:P}     Dolar Compra: {dolarCompra:C2}";

            if (profit < 0)
            {
                lblProfit.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblProfit.ForeColor = System.Drawing.Color.DarkGreen;
            }
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

        private void lblOwnedVentaLast_Click(object sender, EventArgs e)
        {
            numOwnedVentaPrice.Value = _trade.Owned.Dolar.Data.Last.Price.Value;
            numOwnedVentaPrice_KeyPress(sender, null);
        }

        private void lblBookOwnedVentaBid_Click(object sender, EventArgs e)
        {
            numOwnedVentaPrice.Value = _trade.Owned.Dolar.Data.GetTopBidPrice();
            numOwnedVentaSize.Value = _trade.Owned.Dolar.Data.GetTopBidSize();
            numOwnedVentaPrice.ForeColor = System.Drawing.Color.Red;
        }

        private void lblBookOwnedVentaOffer_Click(object sender, EventArgs e)
        {
            numOwnedVentaPrice.Value = _trade.Owned.Dolar.Data.GetTopOfferPrice();
            numOwnedVentaSize.Value = _trade.Owned.Dolar.Data.GetTopOfferSize();
            numOwnedVentaPrice_KeyPress(sender, null);
        }

        private void lblArbitrationCompraLast_Click(object sender, EventArgs e)
        {
            numArbitrationCompraPrice.Value = _trade.Arbitration.Dolar.Data.Last.Price.Value;
            numArbitrationCompraPrice_KeyPress(sender, null);
        }

        private void lblBookArbitrationCompraBid_Click(object sender, EventArgs e)
        {
            numArbitrationCompraPrice.Value = _trade.Arbitration.Dolar.Data.GetTopBidPrice();
            numArbitrationCompraPrice_KeyPress(sender, null);
        }

        private void lblBookArbitrationCompraOffer_Click(object sender, EventArgs e)
        {
            numArbitrationCompraPrice.Value = _trade.Arbitration.Dolar.Data.GetTopOfferPrice();
            numArbitrationCompraPrice.ForeColor = System.Drawing.Color.Red;
        }

        private void lblArbitrationVentaLast_Click(object sender, EventArgs e)
        {
            numArbitrationVentaPrice.Value = _trade.Arbitration.Pesos.Data.Last.Price.Value;
            numArbitrationVentaPrice_KeyPress(sender, null);
        }

        private void lblBookArbitrationVentaBid_Click(object sender, EventArgs e)
        {
            numArbitrationVentaPrice.Value = _trade.Arbitration.Pesos.Data.GetTopBidPrice();
            numArbitrationVentaPrice.ForeColor = System.Drawing.Color.Red;

        }

        private void lblBookArbitrationVentaOffer_Click(object sender, EventArgs e)
        {
            numArbitrationVentaPrice.Value = _trade.Arbitration.Pesos.Data.GetTopOfferPrice();
            numArbitrationVentaPrice_KeyPress(sender, null);
        }

        private void lblOwnedCompraLast_Click(object sender, EventArgs e)
        {
            numOwnedCompraPrice.Value = _trade.Owned.Pesos.Data.Last.Price.Value;
            numOwnedCompraPrice_KeyPress(sender, null);
        }

        private void lblBookOwnedCompraBid_Click(object sender, EventArgs e)
        {
            numOwnedCompraPrice.Value = _trade.Owned.Pesos.Data.GetTopBidPrice();
            numOwnedCompraPrice_KeyPress(sender, null);
        }

        private void lblBookOwnedCompraOffer_Click(object sender, EventArgs e)
        {
            numOwnedCompraPrice.Value = _trade.Owned.Pesos.Data.GetTopOfferPrice();
            numOwnedCompraPrice.ForeColor = System.Drawing.Color.Red;
        }
    }
}
