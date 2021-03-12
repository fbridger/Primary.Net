using Primary.Data;
using Primary.WinFormsApp.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Primary.WinFormsApp
{
    /// <summary>
    /// Permite obtener las posibles operaciones de arbitraje de dolar (MEP o CCL) teniendo en cuenta los diferentes plazos de liquidación habilitados en BYMA
    /// </summary>
    [DebuggerDisplay("{Owned.Ticker} / {Arbitration.Ticker}")]
    public class DolarArbitrationInstruments
    {
        public DolarTradedInstrument Owned { get; set; }
        public DolarTradedInstrument Arbitration { get; set; }

        public DolarArbitrationInstruments(DolarTradedInstrument owned, DolarTradedInstrument arbitration)
        {
            Owned = owned;
            Arbitration = arbitration;
        }

        public bool UpdateData(Instrument instrument, Entries data)
        {
            return Owned.UpdateData(instrument, data) || Arbitration.UpdateData(instrument, data);
        }

        public bool IsCIOpen()
        {
            // convert everything to TimeSpan
            TimeSpan start = new TimeSpan(10, 0, 0);
            TimeSpan end = new TimeSpan(16, 0, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;
            // see if start comes before end
            if (start < end)
                return start <= now && now <= end;
            // start is after end, so do the inverse comparison
            return !(end < now && now < start);
        }

        public IEnumerable<DolarArbitrationTrade> GetTradesBasedOnSettlementTerm(
            DolarTrade owned_SellCI_BuyCI,
            DolarTrade owned_SellCI_Buy24,
            DolarTrade owned_SellCI_Buy48,
            DolarTrade owned_Sell24_Buy24,
            DolarTrade owned_Sell24_Buy48,
            DolarTrade owned_Sell48_Buy48,
            DolarTrade arbitration_BuyCI_SellCI,
            DolarTrade arbitration_BuyCI_Sell24,
            DolarTrade arbitration_BuyCI_Sell48,
            DolarTrade arbitration_Buy24_Sell24,
            DolarTrade arbitration_Buy24_Sell48,
            DolarTrade arbitration_Buy48_Sell48)
        {
            /*
            Op  1	Op 4	Op 2	Op 3	
            Venta	Compra	Compra 	Venta	
            AL30D	AL30	GD30D	GD30	
            CI		CI		CI		CI		
            CI		24		CI		CI		
            CI		48		CI		CI		
            CI		24		CI		24		
            CI		48		CI		24		
            CI		48		CI		48		
            CI		24		24		24		
            CI		48		24		24		
            CI		48		24		48		
            CI		48		48		48		
            24		24		24		24		
            24		48		24		24		
            24		48		24		48		
            24		48		48		48		
            48		48		48		48		
            */

            if (IsCIOpen())
            {
                yield return new DolarArbitrationTrade(owned_SellCI_BuyCI, arbitration_BuyCI_SellCI);
                if (Settings.Default.Enabled24Hours)
                    yield return new DolarArbitrationTrade(owned_SellCI_Buy24, arbitration_BuyCI_SellCI);
                yield return new DolarArbitrationTrade(owned_SellCI_Buy48, arbitration_BuyCI_SellCI);
                if (Settings.Default.Enabled24Hours)
                {
                    yield return new DolarArbitrationTrade(owned_SellCI_Buy24, arbitration_BuyCI_Sell24);
                    yield return new DolarArbitrationTrade(owned_SellCI_Buy48, arbitration_BuyCI_Sell24);
                }
                yield return new DolarArbitrationTrade(owned_SellCI_Buy48, arbitration_BuyCI_Sell48);
                if (Settings.Default.Enabled24Hours)
                {
                    yield return new DolarArbitrationTrade(owned_SellCI_Buy24, arbitration_Buy24_Sell24);
                    yield return new DolarArbitrationTrade(owned_SellCI_Buy48, arbitration_Buy24_Sell24);
                    yield return new DolarArbitrationTrade(owned_SellCI_Buy48, arbitration_Buy24_Sell48);
                }
                yield return new DolarArbitrationTrade(owned_SellCI_Buy48, arbitration_Buy48_Sell48);
            }

            if (Settings.Default.Enabled24Hours)
            {
                yield return new DolarArbitrationTrade(owned_Sell24_Buy24, arbitration_Buy24_Sell24);
                yield return new DolarArbitrationTrade(owned_Sell24_Buy48, arbitration_Buy24_Sell24);
                yield return new DolarArbitrationTrade(owned_Sell24_Buy48, arbitration_Buy24_Sell48);
                yield return new DolarArbitrationTrade(owned_Sell24_Buy48, arbitration_Buy48_Sell48);
            }
            yield return new DolarArbitrationTrade(owned_Sell48_Buy48, arbitration_Buy48_Sell48);
        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares MEP usando el bono en dolares C en Cartera (ejemplo: Venta AL30D / Compra AL30C)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DolarArbitrationTrade> GetSellDolarBuyCableArbitrationTrades()
        {
            var owned_SellCI_BuyCI = new DolarTrade(Owned.CableCI, Owned.DolarCI);
            var owned_SellCI_Buy24 = new DolarTrade(Owned.Cable24, Owned.DolarCI);
            var owned_SellCI_Buy48 = new DolarTrade(Owned.Cable48, Owned.DolarCI);
            var owned_Sell24_Buy24 = new DolarTrade(Owned.Cable24, Owned.Dolar24);
            var owned_Sell24_Buy48 = new DolarTrade(Owned.Cable48, Owned.Dolar24);
            var owned_Sell48_Buy48 = new DolarTrade(Owned.Cable48, Owned.Dolar48);

            var arbitrarion_BuyCI_SellCI = new DolarTrade(Arbitration.CableCI, Arbitration.DolarCI);
            var arbitrarion_BuyCI_Sell24 = new DolarTrade(Arbitration.Cable24, Arbitration.DolarCI);
            var arbitrarion_BuyCI_Sell48 = new DolarTrade(Arbitration.Cable48, Arbitration.DolarCI);
            var arbitrarion_Buy24_Sell24 = new DolarTrade(Arbitration.Cable24, Arbitration.Dolar24);
            var arbitrarion_Buy24_Sell48 = new DolarTrade(Arbitration.Cable48, Arbitration.Dolar24);
            var arbitrarion_Buy48_Sell48 = new DolarTrade(Arbitration.Cable48, Arbitration.Dolar48);


            return GetTradesBasedOnSettlementTerm(
                owned_SellCI_BuyCI,
                owned_SellCI_Buy24,
                owned_SellCI_Buy48,
                owned_Sell24_Buy24,
                owned_Sell24_Buy48,
                owned_Sell48_Buy48,
                arbitrarion_BuyCI_SellCI,
                arbitrarion_BuyCI_Sell24,
                arbitrarion_BuyCI_Sell48,
                arbitrarion_Buy24_Sell24,
                arbitrarion_Buy24_Sell48,
                arbitrarion_Buy48_Sell48
                );
        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares CCL usando el bono en dolares en Cartera (ejemplo: Venta AL30C / Compra AL30D)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DolarArbitrationTrade> GetBuyDolarSellCableArbitrationTrades()
        {
            var owned_SellCI_BuyCI = new DolarTrade(Owned.DolarCI, Owned.CableCI);
            var owned_SellCI_Buy24 = new DolarTrade(Owned.Dolar24, Owned.CableCI);
            var owned_SellCI_Buy48 = new DolarTrade(Owned.Dolar48, Owned.CableCI);
            var owned_Sell24_Buy24 = new DolarTrade(Owned.Dolar24, Owned.Cable24);
            var owned_Sell24_Buy48 = new DolarTrade(Owned.Dolar48, Owned.Cable24);
            var owned_Sell48_Buy48 = new DolarTrade(Owned.Dolar48, Owned.Cable48);

            var arbitrarion_BuyCI_SellCI = new DolarTrade(Arbitration.DolarCI, Arbitration.CableCI);
            var arbitrarion_BuyCI_Sell24 = new DolarTrade(Arbitration.Dolar24, Arbitration.CableCI);
            var arbitrarion_BuyCI_Sell48 = new DolarTrade(Arbitration.Dolar48, Arbitration.CableCI);
            var arbitrarion_Buy24_Sell24 = new DolarTrade(Arbitration.Dolar24, Arbitration.Cable24);
            var arbitrarion_Buy24_Sell48 = new DolarTrade(Arbitration.Dolar48, Arbitration.Cable24);
            var arbitrarion_Buy48_Sell48 = new DolarTrade(Arbitration.Dolar48, Arbitration.Cable48);

            return GetTradesBasedOnSettlementTerm(
                owned_SellCI_BuyCI,
                owned_SellCI_Buy24,
                owned_SellCI_Buy48,
                owned_Sell24_Buy24,
                owned_Sell24_Buy48,
                owned_Sell48_Buy48,
                arbitrarion_BuyCI_SellCI,
                arbitrarion_BuyCI_Sell24,
                arbitrarion_BuyCI_Sell48,
                arbitrarion_Buy24_Sell24,
                arbitrarion_Buy24_Sell48,
                arbitrarion_Buy48_Sell48
                );
        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares CCL usando el bono en Cartera (ejemplo: Venta AL30D / Compra AL30)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DolarArbitrationTrade> GetDolarCableArbitrations()
        {
            var owned_SellCI_BuyCI = new DolarTrade(Owned.PesosCI, Owned.CableCI);
            var owned_SellCI_Buy24 = new DolarTrade(Owned.Pesos24, Owned.CableCI);
            var owned_SellCI_Buy48 = new DolarTrade(Owned.Pesos48, Owned.CableCI);
            var owned_Sell24_Buy24 = new DolarTrade(Owned.Pesos24, Owned.Cable24);
            var owned_Sell24_Buy48 = new DolarTrade(Owned.Pesos48, Owned.Cable24);
            var owned_Sell48_Buy48 = new DolarTrade(Owned.Pesos48, Owned.Cable48);

            var arbitrarion_BuyCI_SellCI = new DolarTrade(Arbitration.PesosCI, Arbitration.CableCI);
            var arbitrarion_BuyCI_Sell24 = new DolarTrade(Arbitration.Pesos24, Arbitration.CableCI);
            var arbitrarion_BuyCI_Sell48 = new DolarTrade(Arbitration.Pesos48, Arbitration.CableCI);
            var arbitrarion_Buy24_Sell24 = new DolarTrade(Arbitration.Pesos24, Arbitration.Cable24);
            var arbitrarion_Buy24_Sell48 = new DolarTrade(Arbitration.Pesos48, Arbitration.Cable24);
            var arbitrarion_Buy48_Sell48 = new DolarTrade(Arbitration.Pesos48, Arbitration.Cable48);

            return GetTradesBasedOnSettlementTerm(
                owned_SellCI_BuyCI,
                owned_SellCI_Buy24,
                owned_SellCI_Buy48,
                owned_Sell24_Buy24,
                owned_Sell24_Buy48,
                owned_Sell48_Buy48,
                arbitrarion_BuyCI_SellCI,
                arbitrarion_BuyCI_Sell24,
                arbitrarion_BuyCI_Sell48,
                arbitrarion_Buy24_Sell24,
                arbitrarion_Buy24_Sell48,
                arbitrarion_Buy48_Sell48
                );
        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares MEP usando el bono en Cartera (ejemplo: Venta AL30D / Compra AL30)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DolarArbitrationTrade> GetDolarMEPArbitrations()
        {
            var owned_SellCI_BuyCI = new DolarTrade(Owned.PesosCI, Owned.DolarCI);
            var owned_SellCI_Buy24 = new DolarTrade(Owned.Pesos24, Owned.DolarCI);
            var owned_SellCI_Buy48 = new DolarTrade(Owned.Pesos48, Owned.DolarCI);
            var owned_Sell24_Buy24 = new DolarTrade(Owned.Pesos24, Owned.Dolar24);
            var owned_Sell24_Buy48 = new DolarTrade(Owned.Pesos48, Owned.Dolar24);
            var owned_Sell48_Buy48 = new DolarTrade(Owned.Pesos48, Owned.Dolar48);

            var arbitrarion_BuyCI_SellCI = new DolarTrade(Arbitration.PesosCI, Arbitration.DolarCI);
            var arbitrarion_BuyCI_Sell24 = new DolarTrade(Arbitration.Pesos24, Arbitration.DolarCI);
            var arbitrarion_BuyCI_Sell48 = new DolarTrade(Arbitration.Pesos48, Arbitration.DolarCI);
            var arbitrarion_Buy24_Sell24 = new DolarTrade(Arbitration.Pesos24, Arbitration.Dolar24);
            var arbitrarion_Buy24_Sell48 = new DolarTrade(Arbitration.Pesos48, Arbitration.Dolar24);
            var arbitrarion_Buy48_Sell48 = new DolarTrade(Arbitration.Pesos48, Arbitration.Dolar48);

            return GetTradesBasedOnSettlementTerm(
                 owned_SellCI_BuyCI,
                 owned_SellCI_Buy24,
                 owned_SellCI_Buy48,
                 owned_Sell24_Buy24,
                 owned_Sell24_Buy48,
                 owned_Sell48_Buy48,
                 arbitrarion_BuyCI_SellCI,
                 arbitrarion_BuyCI_Sell24,
                 arbitrarion_BuyCI_Sell48,
                 arbitrarion_Buy24_Sell24,
                 arbitrarion_Buy24_Sell48,
                 arbitrarion_Buy48_Sell48
                 );
        }

    }
}
