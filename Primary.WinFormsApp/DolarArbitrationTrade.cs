namespace Primary.WinFormsApp
{
    /// <summary>
    /// Permite calcular la ganancia al realizar una operación de arbitraje de dolar (MEP o CCL)
    /// </summary>
    public class DolarArbitrationTrade
    {
        public DolarTrade Owned { get; set; }
        public DolarTrade Arbitration { get; set; }

        public DolarArbitrationTrade(DolarTrade owned, DolarTrade arbitration)
        {
            Owned = owned;
            Arbitration = arbitration;
        }

        public decimal Profit
        {
            get {
                if (Arbitration.Venta > 0 && Owned.Compra > 0)
                {
                    return (Arbitration.Venta / Owned.Compra) - 1;
                }

                return -100;
            }
        }

        public decimal ProfitLast
        {
            get {
                if (Arbitration.Last > 0 && Owned.Last > 0)
                {
                    return (Arbitration.Last / Owned.Last) - 1;
                }

                return -100;
            }
        }

        /// <summary>
        /// Evalua la disponibilidad de nominales en cada una de las cajas de puntas y devuelve la máxima cantidad actualmente disponible
        /// </summary>
        /// <returns></returns>
        public int GetOwnedVentaMaxSize()
        {
            var ownedCompraSize = Owned.Pesos.Data.GetTopBidSize();
            var ownedCompraPrice = Owned.Pesos.Data.GetTopBidPrice();
            var ownedCompra = ownedCompraSize * ownedCompraPrice;

            var arbitrationVentaSize = Arbitration.Pesos.Data.GetTopBidSize();
            var arbitrationVentaPrice = Arbitration.Pesos.Data.GetTopBidPrice();
            var arbitrationVenta = arbitrationVentaSize * arbitrationVentaPrice;

            var arbitrationCompraSize = Arbitration.Dolar.Data.GetTopBidSize();
            var arbitrationCompraPrice = Arbitration.Dolar.Data.GetTopBidPrice();

            var ownedVentaSize = Owned.Pesos.Data.GetTopBidSize();
            var ownedVentaPrice = Owned.Pesos.Data.GetTopBidPrice();

            return 0;
        }
    }
}
