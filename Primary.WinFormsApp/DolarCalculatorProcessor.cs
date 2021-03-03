using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary.WinFormsApp
{
    class DolarCalculatorProcessor
    {
        public List<DolarTradedInstrument> dolarTradedInstruments = new List<DolarTradedInstrument>();

        internal void Init()
        {
            foreach (var arbitrationTicker in Properties.Settings.Default.ArbitrationTickers)
            {
                var arbitration = new DolarTradedInstrument(arbitrationTicker);

                dolarTradedInstruments.Add(arbitration);

            }
        }

        public void RefreshData()
        {
            foreach (var dolarTradedInstrument in dolarTradedInstruments)
            {
                dolarTradedInstrument.RefreshData();
            }
        }

        public List<DolarTrade> GetDolarMEPTrades()
        {
            var trades = new List<DolarTrade>();

            foreach (var dolarArbitrationData in dolarTradedInstruments)
            {
                
                var dolarTrades = dolarArbitrationData.GetDolarMEPCableTrades().Where(x => x.Last > 0 || x.Compra > 0 || x.Venta > 0);
                trades.AddRange(dolarTrades);
                
            }

            return trades;
        }

        public List<DolarTrade> GetDolarCableTrades()
        {
            var trades = new List<DolarTrade>();

            foreach (var dolarArbitrationData in dolarTradedInstruments)
            {
                var dolarTrades = dolarArbitrationData.GetDolarMEPCableTrades().Where(x => x.Last > 0 || x.Compra > 0 || x.Venta > 0);
                trades.AddRange(dolarTrades);
            }

            return trades;
        }
    }
}
