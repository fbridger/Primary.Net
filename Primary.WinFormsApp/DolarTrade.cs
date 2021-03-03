namespace Primary.WinFormsApp
{
    /// <summary>
    /// Permite obtener la cotización para comprar o vender Dolar
    /// </summary>
    public class DolarTrade
    {
        public DolarTrade(InstrumentWithData buy, InstrumentWithData sell)
        {
            Buy = buy;
            Sell = sell;
        }
        public InstrumentWithData Buy { get; set; }
        public InstrumentWithData Sell { get; set; }

        public string Trade
        {
            get {
                return Buy.Instrument.SymbolWithoutPrefix() + " / " + Sell.Instrument.SymbolWithoutPrefix();
            }
        }

        /// <summary>
        /// Obtiene el ultimo tipo de cambio para el Dolar utilizando Pesos.Last / Dolar.Last
        /// </summary>
        public decimal Last
        {
            get {
                if (HasData() && Buy.Data.HasLastPrice() && Sell.Data.HasLastPrice())
                {
                    return Buy.Data.Last.Price.Value / Sell.Data.Last.Price.Value;
                }
                return default;
            }
        }

        /// <summary>
        /// Obtiene el tipo de cambio para Comprar Dolar utilizando Pesos.Offers / Dolar.Bids
        /// </summary>
        public decimal Compra // Barato
        {
            get {
                if (HasData() && Buy.Data.HasOffers() && Sell.Data.HasBids())
                {
                    return Buy.Data.Offers[0].Price / Sell.Data.Bids[0].Price;
                }
                return default;
            }
        }

        /// <summary>
        /// Obtiene el tipo de cambio para Vender Dolar utilizando Pesos.Bids / Dolar.Offers
        /// </summary>
        public decimal Venta // Caro
        {
            get {
                if (HasData() && Buy.Data.HasBids() && Sell.Data.HasOffers())
                {
                    return Buy.Data.Bids[0].Price / Sell.Data.Offers[0].Price;
                }
                return default;
            }
        }

        public bool HasData()
        {
            return Buy.Data != null && Sell.Data != null;
        }
    }
}
