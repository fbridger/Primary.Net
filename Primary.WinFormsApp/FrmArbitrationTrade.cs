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
        private decimal _ownedQuantityPerPrice;
        private decimal _arbitrationQuantityPerPrice;

        public decimal Comision => numComision.Value / 100;

        public FrmArbitrationTrade()
        {
            InitializeComponent();
        }

        private void FrmArbitrationTrade_Load(object sender, EventArgs e)
        {
            numDolar.Value = Properties.Settings.Default.USDARS;
            timer1_Tick(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_trade == null)
                return;

            lblOwnedLast.Text = _trade.Owned.Last.ToCurrency();
            if ( _trade.Owned.Last > 0)
            {
                lblArbitrationDiff.Text = (_trade.Arbitration.Last / _trade.Owned.Last - 1m).ToString("P");
                lblArbitrationLast.Text = _trade.Arbitration.Last.ToCurrency();
            }

            OwnedVentaBidsOffers.LoadData(_trade.Owned.Sell.Data);
            OwnedCompraBidsOffers.LoadData(_trade.Owned.Buy.Data);

            ArbitrationCompraBidsOffers.LoadData(_trade.Arbitration.Sell.Data);
            ArbitrationVentaBidsOffers.LoadData(_trade.Arbitration.Buy.Data);

            if (OwnedVentaPriceAutoUpdate)
            {
                numOwnedVentaPrice.Value = _trade.Owned.Sell.Data.GetTopBidPrice();
            }

            if (ArbitrationCompraPriceAutoUpdate)
            {
                numArbitrationCompraPrice.Value = _trade.Arbitration.Sell.Data.GetTopOfferPrice();
            }

            if (ArbitrationVentaPriceAutoUpdate)
            {
                numArbitrationVentaPrice.Value = _trade.Arbitration.Buy.Data.GetTopBidPrice();
            }

            if (OwnedCompraPriceAutoUpdate)
            {
                numOwnedCompraPrice.Value = _trade.Owned.Buy.Data.GetTopOfferPrice();
            }

        }

        public decimal GetInstrumentPriceQuantity(string ticker)
        {
            if (ticker.StartsWith("AL29")
                || ticker.StartsWith("AL30")
                || ticker.StartsWith("AL35")
                || ticker.StartsWith("AE38")
                || ticker.StartsWith("AL41")
                || ticker.StartsWith("GD29")
                || ticker.StartsWith("GD30")
                || ticker.StartsWith("GD35")
                || ticker.StartsWith("GD38")
                || ticker.StartsWith("GD41")
                || ticker.StartsWith("GD46"))
            {
                return 100m;
            }
            return 1m;
        }

        internal void Init(DolarArbitrationTrade trade)
        {
            _trade = trade;

            OwnedVentaBidsOffers.IsPesos = trade.Owned.Sell.IsPesos;
            OwnedCompraBidsOffers.IsPesos = trade.Owned.Buy.IsPesos;
            ArbitrationVentaBidsOffers.IsPesos = trade.Arbitration.Buy.IsPesos;
            ArbitrationCompraBidsOffers.IsPesos = trade.Arbitration.Sell.IsPesos;

            OwnedVentaBidsOffers.ClickPrice += OwnedVentaBidsOffers_ClickPrice;
            OwnedVentaBidsOffers.ClickSize += OwnedVentaBidsOffers_ClickSize;

            OwnedCompraBidsOffers.ClickPrice += OwnedCompraBidsOffers_ClickPrice;
            OwnedCompraBidsOffers.ClickSize += OwnedCompraBidsOffers_ClickSize;

            ArbitrationCompraBidsOffers.ClickPrice += ArbitrationCompraBidsOffers_ClickPrice;
            ArbitrationCompraBidsOffers.ClickSize += ArbitrationCompraBidsOffers_ClickSize;

            ArbitrationVentaBidsOffers.ClickPrice += ArbitrationVentaBidsOffers_ClickPrice;
            ArbitrationVentaBidsOffers.ClickSize += ArbitrationVentaBidsOffers_ClickSize;

            grpOwnedVenta.Text += " - " + _trade.Owned.Sell.Instrument.SymbolWithoutPrefix();
            grpArbitrationCompra.Text += " - " + _trade.Arbitration.Sell.Instrument.SymbolWithoutPrefix();
            grpArbitrationVenta.Text += " - " + _trade.Arbitration.Buy.Instrument.SymbolWithoutPrefix();
            grpOwnedCompra.Text += " - " + _trade.Owned.Buy.Instrument.SymbolWithoutPrefix();

            _ownedQuantityPerPrice = GetInstrumentPriceQuantity(_trade.Owned.Buy.Instrument.Ticker());
            _arbitrationQuantityPerPrice = GetInstrumentPriceQuantity(_trade.Arbitration.Buy.Instrument.Ticker());

            numOwnedVentaSize.Value = 10000; // TODO: Get Max Size
            if (_trade.Owned.Sell.Data.Last != null)
                numOwnedVentaPrice.Value = _trade.Owned.Sell.Data.Last.Price.Value;

            if (_trade.Arbitration.Sell.Data.Last != null)
                numArbitrationCompraPrice.Value = _trade.Arbitration.Sell.Data.Last.Price.Value;

            if (_trade.Arbitration.Buy.Data.Last != null)
                numArbitrationVentaPrice.Value = _trade.Arbitration.Buy.Data.Last.Price.Value;

            if (_trade.Owned.Buy.Data.Last != null)
                numOwnedCompraPrice.Value = _trade.Owned.Buy.Data.Last.Price.Value;

            this.Text = $"Venta {_trade.Owned.Sell.Instrument.SymbolWithoutPrefix()} -> Compra {_trade.Arbitration.Sell.Instrument.SymbolWithoutPrefix()} -> Venta {_trade.Arbitration.Buy.Instrument.SymbolWithoutPrefix()} -> Compra {_trade.Owned.Buy.Instrument.SymbolWithoutPrefix()}";
            lnkArbitration.Text = Text;

            numOwnedVentaPrice.Increment = _trade.Owned.Sell.IsPesos ? 1 : 0.01m;
            numOwnedCompraPrice.Increment = _trade.Owned.Buy.IsPesos ? 1 : 0.01m;
            numArbitrationVentaPrice.Increment = _trade.Arbitration.Buy.IsPesos ? 1 : 0.01m;
            numArbitrationCompraPrice.Increment = _trade.Arbitration.Sell.IsPesos ? 1 : 0.01m;

            lblDolarSell.Text = $"{_trade.Owned.Sell.Instrument.Ticker()}";
            lblDolarBuy.Text = $"{_trade.Arbitration.Sell.Instrument.Ticker()}";
        }

        public bool ArbitrationVentaPriceAutoUpdate
        {
            get
            {
                return numArbitrationVentaPrice.ForeColor == System.Drawing.Color.Red;
            }
            set
            {
                if (value)
                {
                    numArbitrationVentaPrice.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    numArbitrationVentaPrice.ForeColor = System.Drawing.SystemColors.WindowText;
                }
            }
        }

        public bool ArbitrationCompraPriceAutoUpdate
        {
            get
            {
                return numArbitrationCompraPrice.ForeColor == System.Drawing.Color.Red;
            }
            set
            {
                if (value)
                {
                    numArbitrationCompraPrice.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    numArbitrationCompraPrice.ForeColor = System.Drawing.SystemColors.WindowText;
                }
            }
        }

        public bool OwnedVentaPriceAutoUpdate
        {
            get
            {
                return numOwnedVentaPrice.ForeColor == System.Drawing.Color.Red;
            }
            set
            {
                if (value)
                {
                    numOwnedVentaPrice.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    numOwnedVentaPrice.ForeColor = System.Drawing.SystemColors.WindowText;
                }
            }
        }

        public bool OwnedCompraPriceAutoUpdate
        {
            get
            {
                return numOwnedCompraPrice.ForeColor == System.Drawing.Color.Red;
            }
            set
            {
                if (value)
                {
                    numOwnedCompraPrice.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    numOwnedCompraPrice.ForeColor = System.Drawing.SystemColors.WindowText;
                }
            }
        }

        private void ArbitrationCompraBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
        {
            numArbitrationCompraSize.Value = e.Value;
            // Calcular el size en base al Arbitration Compra Size
            var amount = numArbitrationCompraPrice.Value * numArbitrationCompraSize.Value / _arbitrationQuantityPerPrice;
            UpdateOwnedVentaSizeBasedOnAmount(amount);
        }

        private void ArbitrationCompraBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
        {
            numArbitrationCompraPrice.Value = e.Value;
            ArbitrationCompraPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopOffer;
        }

        private void numArbitrationCompraSize_ValueChanged(object sender, EventArgs e)
        {
            var amount = numArbitrationCompraSize.Value * numArbitrationCompraPrice.Value / _arbitrationQuantityPerPrice;
            UpdateOwnedVentaSizeBasedOnAmount(amount);
        }

        private void ArbitrationVentaBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
        {
            numArbitrationVentaSize.Value = e.Value;
            // Calcular el size en base al Arbitration Venta usando el precio de Arbitration Compra 
            var amount = numArbitrationCompraPrice.Value * numArbitrationVentaSize.Value / _arbitrationQuantityPerPrice;
            UpdateOwnedVentaSizeBasedOnAmount(amount);
        }

        private void ArbitrationVentaBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
        {
            numArbitrationVentaPrice.Value = e.Value;
            ArbitrationVentaPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopBid;
        }

        private void OwnedVentaBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
        {
            numOwnedVentaSize.Value = e.Value;
        }

        private void OwnedVentaBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
        {
            numOwnedVentaPrice.Value = e.Value;
            OwnedVentaPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopBid;
        }

        private void OwnedCompraBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
        {
            // Ajusto el Owned Venta Size y dejo que el Owned Compra se calcule solo
            numOwnedVentaSize.Value = e.Value;
        }

        private void OwnedCompraBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
        {
            numOwnedCompraPrice.Value = e.Value;
            OwnedCompraPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopOffer;
        }

        public void UpdateOwnedVentaSizeBasedOnAmount(decimal amount)
        {
            var ownedSellSize = amount / numOwnedVentaPrice.Value * _ownedQuantityPerPrice;
            if (ownedSellSize < numOwnedVentaSize.Maximum)
            {
                numOwnedVentaSize.Value = Math.Ceiling(ownedSellSize);
            }
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
            if (_ownedQuantityPerPrice > 0)
            {
                _ownedVentaImporte = numOwnedVentaSize.Value * numOwnedVentaPrice.Value / _ownedQuantityPerPrice;
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
                        var size = Math.Floor((_arbitrationVentaImporte - _arbtrationVentaComision - _ownedVentaComision) / numOwnedCompraPrice.Value * _ownedQuantityPerPrice);
                        numOwnedCompraSize.Value = size <= 0 ? 0 : size;
                    }
                    else
                    {
                        var size = Math.Floor((_arbitrationVentaImporte) / numOwnedCompraPrice.Value * _ownedQuantityPerPrice);
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
                numArbitrationCompraSize.Value = Math.Floor((_ownedVentaImporte) / numArbitrationCompraPrice.Value * _arbitrationQuantityPerPrice);
            }
            CalculateArbitrationCompraTotal();
            CalculateArbitrationVentaSize();
            CompleteArbitrationCompra();
        }

        public void CalculateArbitrationCompraTotal()
        {
            lblArbitrationCompraImporte.Text = "Importe: " + (numArbitrationCompraPrice.Value * numArbitrationCompraSize.Value / _arbitrationQuantityPerPrice).ToUSD();
        }

        public void CalculateArbitrationVentaSize()
        {
            numArbitrationVentaSize.Value = numArbitrationCompraSize.Value;

            CalculateArbitrationVentaTotal();
        }

        public void CalculateArbitrationVentaTotal()
        {
            _arbitrationVentaImporte = numArbitrationVentaSize.Value * numArbitrationVentaPrice.Value / _arbitrationQuantityPerPrice;
            if (_trade.Arbitration.Buy.IsPesos)
            {
                _arbtrationVentaComision = _arbitrationVentaImporte * Comision;
            }
            else
            {
                _arbtrationVentaComision = _arbitrationVentaImporte * Comision * numDolar.Value;
            }

            if (_trade.Arbitration.Buy.IsPesos)
            {
                lblArbitrationVentaImporte.Text = "Importe: " + _arbitrationVentaImporte.ToCurrency();
            }
            else
            {
                lblArbitrationVentaImporte.Text = "Importe: " + _arbitrationVentaImporte.ToUSD();
            }

            lblArbitrationComision.Text = "Comisión: " + _arbtrationVentaComision.ToCurrency();

            CompleteArbitrationVenta();
            CalculateOwnedCompraSize();
        }

        public void CalculateOwnedCompraTotalAndProfit()
        {
            var ownedCompraTotal = numOwnedCompraSize.Value * numOwnedCompraPrice.Value / _ownedQuantityPerPrice;
            var ownedCompraSizeInicialTotal = numOwnedVentaSize.Value * numOwnedCompraPrice.Value / _ownedQuantityPerPrice;

            if (_trade.Owned.Buy.IsPesos)
            {
                lblOwnedCompraImporte.Text = "Importe: " + ownedCompraTotal.ToCurrency();
            }
            else
            {
                lblOwnedCompraImporte.Text = "Importe: " + ownedCompraTotal.ToUSD();
            }
            
            lblComisionTotal.Text = "Total Comision: " +  (_ownedVentaComision + _arbtrationVentaComision).ToCurrency();

            var dolarCompra = numOwnedVentaPrice.Value > 0 ? numOwnedCompraPrice.Value / numOwnedVentaPrice.Value : 0;
            var dolarVenta = numArbitrationCompraPrice.Value > 0 ? numArbitrationVentaPrice.Value / numArbitrationCompraPrice.Value : 0;
            var dolarDiff = dolarCompra > 0 ? dolarVenta / dolarCompra - 1 : 0;

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
            lblProfit.Text += Environment.NewLine + $"Dolar Compra: {dolarCompra:C2}     {dolarVenta - dolarCompra:C2} ({dolarDiff:P})     Dolar Venta: {dolarVenta:C2}";

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

        private void numArbitrationCompraPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateArbitrationCompraSize();
        }

        private void numArbitrationVentaPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateArbitrationVentaSize();
        }

        private void numOwnedCompraPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateOwnedCompraSize();
        }

        private void numOwnedVentaPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            OwnedVentaPriceAutoUpdate = false;
        }

        private void numArbitrationCompraPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ArbitrationCompraPriceAutoUpdate = false;
        }

        private void numArbitrationVentaPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ArbitrationVentaPriceAutoUpdate = false;
        }

        private void numOwnedCompraPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            OwnedCompraPriceAutoUpdate = false;
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

        private void lnkArbitration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(lnkArbitration.Text);
        }

        private void numDolar_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.USDARS = numDolar.Value;
            Properties.Settings.Default.Save();
            CalculateOwnedVenta();
        }

        private void numComision_ValueChanged(object sender, EventArgs e)
        {
            CalculateOwnedVenta();
        }
    }
}
