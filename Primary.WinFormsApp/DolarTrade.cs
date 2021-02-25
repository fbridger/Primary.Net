namespace Primary.WinFormsApp
{
    /// <summary>
    /// Permite obtener la cotización para comprar o vender Dolar
    /// </summary>
    public class DolarTrade
    {
        public DolarTrade(InstrumentWithData pesos, InstrumentWithData dolar)
        {
            Pesos = pesos;
            Dolar = dolar;
        }
        public InstrumentWithData Pesos { get; set; }
        public InstrumentWithData Dolar { get; set; }

        /// <summary>
        /// Obtiene el ultimo tipo de cambio para el Dolar utilizando Pesos.Last / Dolar.Last
        /// </summary>
        public decimal Last
        {
            get {
                if (HasData() && Pesos.Data.HasLastPrice() && Dolar.Data.HasLastPrice())
                {
                    return Pesos.Data.Last.Price.Value / Dolar.Data.Last.Price.Value;
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
                if (HasData() && Pesos.Data.HasOffers() && Dolar.Data.HasBids())
                {
                    return Pesos.Data.Offers[0].Price / Dolar.Data.Bids[0].Price;
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
                if (HasData() && Pesos.Data.HasBids() && Dolar.Data.HasOffers())
                {
                    return Pesos.Data.Bids[0].Price / Dolar.Data.Offers[0].Price;
                }
                return default;
            }
        }

        public bool HasData()
        {
            return Pesos.Data != null && Dolar.Data != null;
        }
    }
}
