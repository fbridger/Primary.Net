using Primary.Data;
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

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares MEP usando el bono en dolares C en Cartera (ejemplo: Venta AL30D / Compra AL30C)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DolarArbitrationTrade> GetSellDolarBuyCableArbitrationTrades()
        {
            var ventaD_CI_compraP_CI = new DolarTrade(Owned.CableCI, Owned.DolarCI);
            var ventaD_CI_compraP_24 = new DolarTrade(Owned.Cable24, Owned.DolarCI);
            var ventaD_CI_compraP_48 = new DolarTrade(Owned.Cable48, Owned.DolarCI);
            var ventaD_24_compraP_24 = new DolarTrade(Owned.Cable24, Owned.Dolar24);
            var ventaD_24_compraP_48 = new DolarTrade(Owned.Cable48, Owned.Dolar24);
            var ventaD_48_compraP_48 = new DolarTrade(Owned.Cable48, Owned.Dolar48);

            var compraD_CI_ventaP_CI = new DolarTrade(Arbitration.CableCI, Arbitration.DolarCI);
            var compraD_CI_ventaP_24 = new DolarTrade(Arbitration.Cable24, Arbitration.DolarCI);
            var compraD_CI_ventaP_48 = new DolarTrade(Arbitration.Cable48, Arbitration.DolarCI);
            var compraD_24_ventaP_24 = new DolarTrade(Arbitration.Cable24, Arbitration.Dolar24);
            var compraD_24_ventaP_48 = new DolarTrade(Arbitration.Cable48, Arbitration.Dolar24);
            var compraD_48_ventaP_48 = new DolarTrade(Arbitration.Cable48, Arbitration.Dolar48);


            if (IsCIOpen())
            {
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_CI, compraD_CI_ventaP_CI);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_24, compraD_CI_ventaP_CI);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_CI_ventaP_CI);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_24, compraD_CI_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_CI_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_CI_ventaP_48);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_24, compraD_24_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_24_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_24_ventaP_48);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_48_ventaP_48);
            }
            yield return new DolarArbitrationTrade(ventaD_24_compraP_24, compraD_24_ventaP_24);
            yield return new DolarArbitrationTrade(ventaD_24_compraP_48, compraD_24_ventaP_24);
            yield return new DolarArbitrationTrade(ventaD_24_compraP_48, compraD_24_ventaP_48);
            yield return new DolarArbitrationTrade(ventaD_24_compraP_48, compraD_48_ventaP_48);
            yield return new DolarArbitrationTrade(ventaD_48_compraP_48, compraD_48_ventaP_48);
        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares CCL usando el bono en dolares en Cartera (ejemplo: Venta AL30C / Compra AL30D)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DolarArbitrationTrade> GetBuyDolarSellCableArbitrationTrades()
        {
            var ventaD_CI_compraP_CI = new DolarTrade(Owned.DolarCI, Owned.CableCI);
            var ventaD_CI_compraP_24 = new DolarTrade(Owned.Dolar24, Owned.CableCI);
            var ventaD_CI_compraP_48 = new DolarTrade(Owned.Dolar48, Owned.CableCI);
            var ventaD_24_compraP_24 = new DolarTrade(Owned.Dolar24, Owned.Cable24);
            var ventaD_24_compraP_48 = new DolarTrade(Owned.Dolar48, Owned.Cable24);
            var ventaD_48_compraP_48 = new DolarTrade(Owned.Dolar48, Owned.Cable48);

            var compraD_CI_ventaP_CI = new DolarTrade(Arbitration.DolarCI, Arbitration.CableCI);
            var compraD_CI_ventaP_24 = new DolarTrade(Arbitration.Dolar24, Arbitration.CableCI);
            var compraD_CI_ventaP_48 = new DolarTrade(Arbitration.Dolar48, Arbitration.CableCI);
            var compraD_24_ventaP_24 = new DolarTrade(Arbitration.Dolar24, Arbitration.Cable24);
            var compraD_24_ventaP_48 = new DolarTrade(Arbitration.Dolar48, Arbitration.Cable24);
            var compraD_48_ventaP_48 = new DolarTrade(Arbitration.Dolar48, Arbitration.Cable48);

            if (IsCIOpen())
            {
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_CI, compraD_CI_ventaP_CI);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_24, compraD_CI_ventaP_CI);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_CI_ventaP_CI);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_24, compraD_CI_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_CI_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_CI_ventaP_48);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_24, compraD_24_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_24_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_24_ventaP_48);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_48_ventaP_48);
            }
            yield return new DolarArbitrationTrade(ventaD_24_compraP_24, compraD_24_ventaP_24);
            yield return new DolarArbitrationTrade(ventaD_24_compraP_48, compraD_24_ventaP_24);
            yield return new DolarArbitrationTrade(ventaD_24_compraP_48, compraD_24_ventaP_48);
            yield return new DolarArbitrationTrade(ventaD_24_compraP_48, compraD_48_ventaP_48);
            yield return new DolarArbitrationTrade(ventaD_48_compraP_48, compraD_48_ventaP_48);
        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares CCL usando el bono en Cartera (ejemplo: Venta AL30D / Compra AL30)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DolarArbitrationTrade> GetBuyPesosSellCableArbitrationTrades()
        {
            var ventaD_CI_compraP_CI = new DolarTrade(Owned.PesosCI, Owned.CableCI);
            var ventaD_CI_compraP_24 = new DolarTrade(Owned.Pesos24, Owned.CableCI);
            var ventaD_CI_compraP_48 = new DolarTrade(Owned.Pesos48, Owned.CableCI);
            var ventaD_24_compraP_24 = new DolarTrade(Owned.Pesos24, Owned.Cable24);
            var ventaD_24_compraP_48 = new DolarTrade(Owned.Pesos48, Owned.Cable24);
            var ventaD_48_compraP_48 = new DolarTrade(Owned.Pesos48, Owned.Cable48);

            var compraD_CI_ventaP_CI = new DolarTrade(Arbitration.PesosCI, Arbitration.CableCI);
            var compraD_CI_ventaP_24 = new DolarTrade(Arbitration.Pesos24, Arbitration.CableCI);
            var compraD_CI_ventaP_48 = new DolarTrade(Arbitration.Pesos48, Arbitration.CableCI);
            var compraD_24_ventaP_24 = new DolarTrade(Arbitration.Pesos24, Arbitration.Cable24);
            var compraD_24_ventaP_48 = new DolarTrade(Arbitration.Pesos48, Arbitration.Cable24);
            var compraD_48_ventaP_48 = new DolarTrade(Arbitration.Pesos48, Arbitration.Cable48);

            /*
            Op  1	Op 2	Op 3	Op 4
            Venta	Compra 	Venta	Compra
            AL30C	GD30C	GD30	AL30
            CI		CI		CI		CI
            CI		CI		CI		24
            CI		CI		CI		48
            CI		CI		24		24
            CI		CI		24		48
            CI		CI		48		48
            CI		24		24		24
            CI		24		24		48
            CI		24		48		48
            CI		48		48		48
            24		24		24		24
            24		24		24		48
            24		24		48		48
            24		48		48		48
            48		48		48		48
            */

            if (IsCIOpen())
            {
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_CI, compraD_CI_ventaP_CI);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_24, compraD_CI_ventaP_CI);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_CI_ventaP_CI);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_24, compraD_CI_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_CI_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_CI_ventaP_48);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_24, compraD_24_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_24_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_24_ventaP_48);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_48_ventaP_48);
            }
            yield return new DolarArbitrationTrade(ventaD_24_compraP_24, compraD_24_ventaP_24);
            yield return new DolarArbitrationTrade(ventaD_24_compraP_48, compraD_24_ventaP_24);
            yield return new DolarArbitrationTrade(ventaD_24_compraP_48, compraD_24_ventaP_48);
            yield return new DolarArbitrationTrade(ventaD_24_compraP_48, compraD_48_ventaP_48);
            yield return new DolarArbitrationTrade(ventaD_48_compraP_48, compraD_48_ventaP_48);
        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares MEP usando el bono en Cartera (ejemplo: Venta AL30D / Compra AL30)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DolarArbitrationTrade> GetBuyPesosSellDolarArbitrationTrades()
        {
            var ventaD_CI_compraP_CI = new DolarTrade(Owned.PesosCI, Owned.DolarCI);
            var ventaD_CI_compraP_24 = new DolarTrade(Owned.Pesos24, Owned.DolarCI);
            var ventaD_CI_compraP_48 = new DolarTrade(Owned.Pesos48, Owned.DolarCI);
            var ventaD_24_compraP_24 = new DolarTrade(Owned.Pesos24, Owned.Dolar24);
            var ventaD_24_compraP_48 = new DolarTrade(Owned.Pesos48, Owned.Dolar24);
            var ventaD_48_compraP_48 = new DolarTrade(Owned.Pesos48, Owned.Dolar48);

            var compraD_CI_ventaP_CI = new DolarTrade(Arbitration.PesosCI, Arbitration.DolarCI);
            var compraD_CI_ventaP_24 = new DolarTrade(Arbitration.Pesos24, Arbitration.DolarCI);
            var compraD_CI_ventaP_48 = new DolarTrade(Arbitration.Pesos48, Arbitration.DolarCI);
            var compraD_24_ventaP_24 = new DolarTrade(Arbitration.Pesos24, Arbitration.Dolar24);
            var compraD_24_ventaP_48 = new DolarTrade(Arbitration.Pesos48, Arbitration.Dolar24);
            var compraD_48_ventaP_48 = new DolarTrade(Arbitration.Pesos48, Arbitration.Dolar48);

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
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_CI, compraD_CI_ventaP_CI);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_24, compraD_CI_ventaP_CI);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_CI_ventaP_CI);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_24, compraD_CI_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_CI_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_CI_ventaP_48);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_24, compraD_24_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_24_ventaP_24);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_24_ventaP_48);
                yield return new DolarArbitrationTrade(ventaD_CI_compraP_48, compraD_48_ventaP_48);
            }
            yield return new DolarArbitrationTrade(ventaD_24_compraP_24, compraD_24_ventaP_24);
            yield return new DolarArbitrationTrade(ventaD_24_compraP_48, compraD_24_ventaP_24);
            yield return new DolarArbitrationTrade(ventaD_24_compraP_48, compraD_24_ventaP_48);
            yield return new DolarArbitrationTrade(ventaD_24_compraP_48, compraD_48_ventaP_48);
            yield return new DolarArbitrationTrade(ventaD_48_compraP_48, compraD_48_ventaP_48);
        }

    }
}
