using System.Collections.Generic;
using System.Linq;

namespace Primary.WinFormsApp
{
    public class TradedInstrumentWithSettlementTerms
    {
        public TradedInstrumentWithSettlementTerms(string ticker, bool isPesos)
        {
            Ticker = ticker;

            T48 = new InstrumentWithData(Argentina.Data.AllInstruments.Single(x => x.Symbol == ticker.ToMervalSymbol48H()), isPesos);
            T24 = new InstrumentWithData(Argentina.Data.AllInstruments.Single(x => x.Symbol == ticker.ToMervalSymbol24H()), isPesos);
            TCI = new InstrumentWithData(Argentina.Data.AllInstruments.Single(x => x.Symbol == ticker.ToMervalSymbolCI()), isPesos);

        }

        public string Ticker { get; private set; }

        public InstrumentWithData T48 { get; set; }
        public InstrumentWithData T24 { get; set; }
        public InstrumentWithData TCI { get; set; }

        public override string ToString()
        {
            return Ticker + " " + base.ToString();
        }

        public virtual void RefreshData()
        {
            T48.RefreshData();
            T24.RefreshData();
            TCI.RefreshData();
        }

        public IEnumerable<SettlementTermTrade> GetSettlementTermTrades(decimal minProfitPercentage)
        {
            var t48_24 = GetSettlementTermTrade(T48, T24, minProfitPercentage);
            if (t48_24 != null)
                yield return t48_24;

            var t48_CI   = GetSettlementTermTrade(T48, TCI, minProfitPercentage);
            if (t48_CI != null)
                yield return t48_CI;

            var t24_48 = GetSettlementTermTrade(T24, T48, minProfitPercentage);
            if (t24_48 != null)
                yield return t24_48;

            var t24_CI = GetSettlementTermTrade(T24, TCI, minProfitPercentage);
            if (t24_CI != null)
                yield return t24_CI;

            var tCI_48 = GetSettlementTermTrade(TCI, T48, minProfitPercentage);
            if (tCI_48 != null)
                yield return tCI_48;

            var tCI_24 = GetSettlementTermTrade(TCI, T24, minProfitPercentage);
            if (tCI_24 != null)
                yield return tCI_24;

        }

        private static SettlementTermTrade GetSettlementTermTrade(InstrumentWithData buy, InstrumentWithData sell, decimal minProfitPercentage)
        {
            if (sell.Data.HasBids() && buy.Data.HasOffers())
            {
                var sellPrice = sell.Data.GetTopBidPrice();
                var buyPrice = buy.Data.GetTopOfferPrice();
                var diffPct = sellPrice / buyPrice - 1m;
                if (minProfitPercentage <= diffPct)
                {
                    return new SettlementTermTrade(buy, sell);
                }
            }

            return null;
        }
    }
}
