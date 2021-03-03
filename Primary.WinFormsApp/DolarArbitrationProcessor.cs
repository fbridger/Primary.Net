using Primary.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Primary.WinFormsApp
{

    public class DolarArbitrationProcessor
    {
        public List<DolarArbitrationInstruments> dolarArbitrationPairCollection = new List<DolarArbitrationInstruments>();

        internal void Init()
        {
            foreach (var ownedTicker in Properties.Settings.Default.OwnedTickers)
            {
                var owned = new DolarTradedInstrument(ownedTicker);

                foreach (var arbitrationTicker in Properties.Settings.Default.ArbitrationTickers)
                {
                    if (ownedTicker != arbitrationTicker)
                    {
                        var arbitration = new DolarTradedInstrument(arbitrationTicker);

                        dolarArbitrationPairCollection.Add(new DolarArbitrationInstruments(owned, arbitration));
                    }
                }
            }
        }

        public void RefreshData()
        {
            foreach (var dolarArbitrationData in dolarArbitrationPairCollection)
            {
                dolarArbitrationData.Owned.RefreshData();
                dolarArbitrationData.Arbitration.RefreshData();
            }
        }

        public List<DolarArbitrationTrade> GetArbitrationTrades()
        {
            var trades = new List<DolarArbitrationTrade>();

            foreach (var dolarArbitrationData in dolarArbitrationPairCollection)
            {
                
                var dolarTrades = dolarArbitrationData.GetBuyPesosSellDolarArbitrationTrades();
                trades.AddRange(dolarTrades.Where(x => x.Profit > 0.005m || x.ProfitLast > 0.005m));
                var cableTrades = dolarArbitrationData.GetBuyPesosSellCableArbitrationTrades();
                trades.AddRange(cableTrades.Where(x => x.Profit > 0.005m || x.ProfitLast > 0.005m));
                

                var dolarCableTrades = dolarArbitrationData.GetBuyDolarSellCableArbitrationTrades();
                trades.AddRange(dolarCableTrades.Where(x => x.Profit > 0.005m || x.ProfitLast > 0.005m));

                var cableDolarTrades = dolarArbitrationData.GetSellDolarBuyCableArbitrationTrades();
                trades.AddRange(cableDolarTrades.Where(x => x.Profit > 0.005m || x.ProfitLast > 0.005m));
            }

            return trades;
        }

        public void OnMarketData(Instrument instrument, Entries data)
        {
            try
            {
                foreach (var item in dolarArbitrationPairCollection)
                {
                    item.UpdateData(instrument, data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
