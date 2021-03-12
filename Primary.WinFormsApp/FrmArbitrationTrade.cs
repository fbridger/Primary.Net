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
            if ( _trade.Owned.Last > 0)
            {
                lblArbitrationDiff.Text = (_trade.Arbitration.Last / _trade.Owned.Last - 1m).ToString("P");
                lblArbitrationLast.Text = _trade.Arbitration.Last.ToCurrency();
            }

            if (_trade.Owned.Sell.Data.Last != null)
                lblOwnedVentaLast.Text = _trade.Owned.Sell.Data.Last.Price.Value.ToUSD();

            if (!OwnedVentaChanged())
            {
                numOwnedVentaPrice.Value = _trade.Owned.Sell.Data.GetTopBidPrice();
            }
            lblBookOwnedVentaBid.Text = _trade.Owned.Sell.Data.ToReadableBids();
            lblBookOwnedVentaOffer.Text = _trade.Owned.Sell.Data.ToReadableOffers();

            if (_trade.Arbitration.Sell.Data.Last != null)
            {
                lblArbitrationCompraLast.Text = _trade.Arbitration.Sell.Data.Last.Price.Value.ToUSD();
            }
            if (!ArbitrationCompraChanged())
            {
                numArbitrationCompraPrice.Value = _trade.Arbitration.Sell.Data.GetTopOfferPrice();
            }
            lblBookArbitrationCompraBid.Text = _trade.Arbitration.Sell.Data.ToReadableBids();
            lblBookArbitrationCompraOffer.Text = _trade.Arbitration.Sell.Data.ToReadableOffers();

            if (_trade.Arbitration.Buy.Data.Last != null)
            {
                lblArbitrationVentaLast.Text = _trade.Arbitration.Buy.Data.Last.Price.Value.ToCurrency();
            }
            if (!ArbitrationVentaChanged())
            {
                numArbitrationVentaPrice.Value = _trade.Arbitration.Buy.Data.GetTopBidPrice();
            }
            lblBookArbitrationVentaBid.Text = _trade.Arbitration.Buy.Data.ToReadableBids();
            lblBookArbitrationVentaOffer.Text = _trade.Arbitration.Buy.Data.ToReadableOffers();

            lblOwnedCompraLast.Text = _trade.Owned.Buy.Data.Last.Price.Value.ToCurrency();
            if (!OwnedCompraChanged())
            {
                numOwnedCompraPrice.Value = _trade.Owned.Buy.Data.GetTopOfferPrice();
            }
            lblBookOwnedCompraBid.Text = _trade.Owned.Buy.Data.ToReadableBids();
            lblBookOwnedCompraOffer.Text = _trade.Owned.Buy.Data.ToReadableOffers();

        }

        internal void Init(DolarArbitrationTrade trade)
        {
            _trade = trade;

            grpOwnedVenta.Text += " - " + _trade.Owned.Sell.Instrument.SymbolWithoutPrefix();
            grpArbitrationCompra.Text += " - " + _trade.Arbitration.Sell.Instrument.SymbolWithoutPrefix();
            grpArbitrationVenta.Text += " - " + _trade.Arbitration.Buy.Instrument.SymbolWithoutPrefix();
            grpOwnedCompra.Text += " - " + _trade.Owned.Buy.Instrument.SymbolWithoutPrefix();

            numOwnedVentaSize.Value = 10000; // TODO: Get Max Size
            if (_trade.Owned.Sell.Data.Last != null)
                numOwnedVentaPrice.Value = _trade.Owned.Sell.Data.Last.Price.Value;

            if (_trade.Arbitration.Sell.Data.Last != null)
                numArbitrationCompraPrice.Value = _trade.Arbitration.Sell.Data.Last.Price.Value;

            if (_trade.Arbitration.Buy.Data.Last != null)
                numArbitrationVentaPrice.Value = _trade.Arbitration.Buy.Data.Last.Price.Value;

            if (_trade.Owned.Buy.Data.Last != null)
                numOwnedCompraPrice.Value = _trade.Owned.Buy.Data.Last.Price.Value;

            this.Text = $"{_trade.Owned.Sell.Instrument.SymbolWithoutPrefix()} -> {_trade.Arbitration.Sell.Instrument.SymbolWithoutPrefix()} -> {_trade.Arbitration.Buy.Instrument.SymbolWithoutPrefix()} -> {_trade.Owned.Buy.Instrument.SymbolWithoutPrefix()}";


            numOwnedVentaPrice.Increment = _trade.Owned.Sell.IsPesos ? 1 : 0.01m;
            numOwnedCompraPrice.Increment = _trade.Owned.Buy.IsPesos ? 1 : 0.01m;
            numArbitrationVentaPrice.Increment = _trade.Arbitration.Sell.IsPesos ? 1 : 0.01m;
            numArbitrationCompraPrice.Increment = _trade.Arbitration.Buy.IsPesos ? 1 : 0.01m;
        }

        public void CompleteOwnedVenta()
        {
            txtOwnedVenta.Text = $"VENDER {numOwnedVentaSize.Value:#,##0} nominales de {_trade.Owned.Sell.Instrument.SymbolWithoutPrefix()} a {numOwnedVentaPrice.Value:#,##0.00}";
        }

        public void CompleteOwnedCompra()
        {
            txtOwnedCompra.Text = $"COMPRAR {numOwnedCompraSize.Value:#,##0} nominales de {_trade.Owned.Buy.Instrument.SymbolWithoutPrefix()} a {numOwnedCompraPrice.Value:#,##0.00}";
        }

        public void CompleteArbitrationVenta()
        {
            txtArbitrationVenta.Text = $"VENDER {numArbitrationVentaSize.Value:#,##0} nominales de {_trade.Arbitration.Buy.Instrument.SymbolWithoutPrefix()} a {numArbitrationVentaPrice.Value:#,##0.00}";
        }

        public void CompleteArbitrationCompra()
        {
            txtArbitrationCompra.Text = $"COMPRAR {numArbitrationCompraSize.Value:#,##0} nominales de {_trade.Arbitration.Sell.Instrument.SymbolWithoutPrefix()} a {numArbitrationCompraPrice.Value:#,##0.00}";
        }

        public void CalculateOwnedVenta()
        {
            CompleteOwnedVenta();
            _ownedVentaImporte = numOwnedVentaSize.Value * numOwnedVentaPrice.Value / 100m;
            if (_trade.Owned.Sell.IsPesos)
            {
                _ownedVentaComision = _ownedVentaImporte * Comision;
            }
            else
            {
                _ownedVentaComision = _ownedVentaImporte * Comision * numDolar.Value;
            }

            lblOwnedVentaImporte.Text = "Importe: " + _ownedVentaImporte.ToUSD();
            lblOwnedComision.Text = "Comisión: " + _ownedVentaComision.ToCurrency();

            CalculateArbitrationCompraSize();
        }

        public void CalculateOwnedCompraSize()
        {
            if (!chkComprarNominales.Checked)
            {
                numOwnedCompraSize.Value = numOwnedVentaSize.Value;
            }
            else
            {
                if (numOwnedCompraPrice.Value > 0)
                {
                    if (_trade.Arbitration.Buy.IsPesos)
                    {
                        //var comisionUSD = (_arbtrationVentaComision + _ownedVentaComision) * numDolar.Value;
                        var size = Math.Floor((_arbitrationVentaImporte - _arbtrationVentaComision - _ownedVentaComision) / numOwnedCompraPrice.Value * 100m);
                        numOwnedCompraSize.Value = size <= 0 ? 0 : size;
                    }
                    else
                    {
                        var size = Math.Floor((_arbitrationVentaImporte) / numOwnedCompraPrice.Value * 100m);
                        numOwnedCompraSize.Value = size <= 0 ? 0 : size;
                    }
                }
            }

            CalculateOwnedCompraTotalAndProfit();
        }

        public void CalculateArbitrationCompraSize()
        {
            if (numArbitrationCompraPrice.Value > 0)
            {
                numArbitrationCompraSize.Value = (_ownedVentaImporte) / numArbitrationCompraPrice.Value * 100m;
            }
            CalculateArbitrationCompraTotal();
            CalculateArbitrationVentaSize();
            CompleteArbitrationCompra();
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
            if (_trade.Arbitration.Buy.IsPesos)
            {
                _arbtrationVentaComision = _arbitrationVentaImporte * Comision;
            }
            else
            {
                _arbtrationVentaComision = _arbitrationVentaImporte * Comision * numDolar.Value;
            }

            lblArbitrationVentaImporte.Text = "Importe: " + _arbitrationVentaImporte.ToCurrency();
            lblArbitrationComision.Text = "Comisión: " + _arbtrationVentaComision.ToCurrency();

            CompleteArbitrationVenta();
            CalculateOwnedCompraSize();
        }

        public void CalculateOwnedCompraTotalAndProfit()
        {
            var ownedCompraTotal = numOwnedCompraSize.Value * numOwnedCompraPrice.Value / 100m;
            var ownedCompraSizeInicialTotal = numOwnedVentaSize.Value * numOwnedCompraPrice.Value / 100m;
            lblOwnedCompraImporte.Text = "Importe: " + ownedCompraTotal.ToCurrency();
            lblComisionTotal.Text = "Total Comision: " +  (_ownedVentaComision + _arbtrationVentaComision).ToCurrency();

            var dolarVenta = numOwnedVentaPrice.Value > 0 ? numOwnedCompraPrice.Value / numOwnedVentaPrice.Value : 0;
            var dolarCompra = numArbitrationCompraPrice.Value > 0 ? numArbitrationVentaPrice.Value / numArbitrationCompraPrice.Value : 0;
            var dolarDiff = dolarVenta > 0 ? dolarCompra / dolarVenta - 1 : 0;

            decimal profit;

            if (_trade.Owned.Buy.IsPesos)
            {
                profit = _arbitrationVentaImporte - ownedCompraSizeInicialTotal - _ownedVentaComision - _arbtrationVentaComision;
                lblTotalProfit.Text = "Total: " + (_arbitrationVentaImporte - ownedCompraSizeInicialTotal).ToCurrency();
            }
            else
            {
                profit = (_arbitrationVentaImporte - ownedCompraSizeInicialTotal) * numDolar.Value - _ownedVentaComision - _arbtrationVentaComision;
                lblTotalProfit.Text = "Total: " + (_arbitrationVentaImporte - ownedCompraSizeInicialTotal).ToUSD();
            }
            lblProfit.Text = "Profit: " + profit.ToCurrency();
            lblProfit.Text += Environment.NewLine + $"Dolar Venta: {dolarVenta:C2}     {dolarDiff:P}     Dolar Compra: {dolarCompra:C2}";

            if (chkComprarNominales.Checked)
            {
                lblProfitPesos.Text = "Profit Nominales : " + (numOwnedCompraSize.Value - numOwnedVentaSize.Value) + " Dif. " + (profit).ToCurrency();
            }
            else
            {
                lblProfitPesos.Text = "Profit: " + profit.ToCurrency();
            }

            if (profit < 0)
            {
                lblProfit.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblProfit.ForeColor = System.Drawing.Color.DarkGreen;
            }


            CompleteOwnedCompra();
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
            CalculateOwnedCompraSize();
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
            numOwnedVentaPrice.Value = _trade.Owned.Sell.Data.Last.Price.Value;
            numOwnedVentaPrice_KeyPress(sender, null);
        }

        private void lblBookOwnedVentaBid_Click(object sender, EventArgs e)
        {
            numOwnedVentaPrice.Value = _trade.Owned.Sell.Data.GetTopBidPrice();
            //numOwnedVentaSize.Value = _trade.Owned.Sell.Data.GetTopBidSize();
            numOwnedVentaPrice.ForeColor = System.Drawing.Color.Red;
        }

        private void lblBookOwnedVentaOffer_Click(object sender, EventArgs e)
        {
            numOwnedVentaPrice.Value = _trade.Owned.Sell.Data.GetTopOfferPrice();
            //numOwnedVentaSize.Value = _trade.Owned.Sell.Data.GetTopOfferSize();
            numOwnedVentaPrice_KeyPress(sender, null);
        }

        private void lblArbitrationCompraLast_Click(object sender, EventArgs e)
        {
            numArbitrationCompraPrice.Value = _trade.Arbitration.Sell.Data.Last.Price.Value;
            numArbitrationCompraPrice_KeyPress(sender, null);
        }

        private void lblBookArbitrationCompraBid_Click(object sender, EventArgs e)
        {
            numArbitrationCompraPrice.Value = _trade.Arbitration.Sell.Data.GetTopBidPrice();
            numArbitrationCompraPrice_KeyPress(sender, null);
        }

        private void lblBookArbitrationCompraOffer_Click(object sender, EventArgs e)
        {
            numArbitrationCompraPrice.Value = _trade.Arbitration.Sell.Data.GetTopOfferPrice();
            numArbitrationCompraPrice.ForeColor = System.Drawing.Color.Red;
        }

        private void lblArbitrationVentaLast_Click(object sender, EventArgs e)
        {
            numArbitrationVentaPrice.Value = _trade.Arbitration.Buy.Data.Last.Price.Value;
            numArbitrationVentaPrice_KeyPress(sender, null);
        }

        private void lblBookArbitrationVentaBid_Click(object sender, EventArgs e)
        {
            numArbitrationVentaPrice.Value = _trade.Arbitration.Buy.Data.GetTopBidPrice();
            numArbitrationVentaPrice.ForeColor = System.Drawing.Color.Red;

        }

        private void lblBookArbitrationVentaOffer_Click(object sender, EventArgs e)
        {
            numArbitrationVentaPrice.Value = _trade.Arbitration.Buy.Data.GetTopOfferPrice();
            numArbitrationVentaPrice_KeyPress(sender, null);
        }

        private void lblOwnedCompraLast_Click(object sender, EventArgs e)
        {
            numOwnedCompraPrice.Value = _trade.Owned.Buy.Data.Last.Price.Value;
            numOwnedCompraPrice_KeyPress(sender, null);
        }

        private void lblBookOwnedCompraBid_Click(object sender, EventArgs e)
        {
            numOwnedCompraPrice.Value = _trade.Owned.Buy.Data.GetTopBidPrice();
            numOwnedCompraPrice_KeyPress(sender, null);
        }

        private void lblBookOwnedCompraOffer_Click(object sender, EventArgs e)
        {
            numOwnedCompraPrice.Value = _trade.Owned.Buy.Data.GetTopOfferPrice();
            numOwnedCompraPrice.ForeColor = System.Drawing.Color.Red;
        }

        private void chkComprarNominales_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOwnedCompraSize();
        }

        private void txtOwnedVenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtOwnedVenta.Text);
        }

        private void txtArbitrationCompra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtArbitrationCompra.Text);
        }

        private void txtArbitrationVenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtArbitrationVenta.Text);
        }

        private void txtOwnedCompra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtOwnedCompra.Text);
        }
    }
}
