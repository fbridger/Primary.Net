using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary.WinFormsApp
{
    public class SettlementTermTrade
    {
        public SettlementTermTrade(InstrumentWithData buy, InstrumentWithData sell)
        {
            Buy = buy;
            Sell = sell;
        }
        public InstrumentWithData Sell { get; private set; }
        public InstrumentWithData Buy { get; private set; }

        public decimal Profit
        {
            get
            {
                if (HasData() && Sell.Data.HasBids() && Buy.Data.HasOffers())
                {
                    var sellPrice = Sell.Data.GetTopBidPrice();
                    var buyPrice = Buy.Data.GetTopOfferPrice();
                    var diffPct = sellPrice / buyPrice - 1m;
                    return diffPct;
                }
                return -100m;
            }
        }

        public decimal ProfitLast
        {
            get
            {
                if (HasData() && Buy.Data.HasLastPrice() && Sell.Data.HasLastPrice())
                {
                    return Buy.Data.Last.Price.Value / Sell.Data.Last.Price.Value -1;
                }
                return -100m;
            }
        }

        public decimal BuyPrice // Barato
        {
            get
            {
                if (Buy.Data != null && Buy.Data.HasOffers())
                {
                    return Buy.Data.Offers[0].Price ;
                }
                return default;
            }
        }

        public decimal SellPrice // Caro
        {
            get
            {
                if (Sell.Data != null && Sell.Data.HasOffers())
                {
                    return Sell.Data.Bids[0].Price;
                }
                return default;
            }
        }

        public bool HasData()
        {
            return Buy.Data != null && Sell.Data != null;
        }
    }

    public class SettlementTermArbitrationProcessor
    {
        public List<DolarTradedInstrument> tradedInstruments = new List<DolarTradedInstrument>();

        internal void Init()
        {
            foreach (var ownedTicker in Properties.Settings.Default.ArbitrationTickers)
            {
                var dolarTradedInstrument = new DolarTradedInstrument(ownedTicker);
                tradedInstruments.Add(dolarTradedInstrument);
            }
        }

        public void RefreshData()
        {
            foreach (var dolarTradedInstrument in tradedInstruments)
            {
                dolarTradedInstrument.RefreshData();
            }
        }

        public List<SettlementTermTrade> GetSettlementTermTrades(decimal minProfitPercentage)
        {
            var allTrades = new List<SettlementTermTrade>();

            foreach (var tradedInstrument in tradedInstruments)
            {
                var trades = tradedInstrument.GetSettlementTermTrades(minProfitPercentage);
                if (trades != null && trades.Count() > 0)
                    allTrades.AddRange(trades);

            }

            return allTrades;
        }
    }
}

