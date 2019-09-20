using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Primary.Data
{
    [DebuggerDisplay("{Last.Price.GetValueOrDefault().ToString(\"C\")} {ChangePercentage.ToString(\"P1\")} {EffectiveVolume.GetValueOrDefault().ToString(\"C0\")}")]
    public class InstrumentMarketData
    {
        [JsonProperty("OP")]
        public decimal? Open { get; set; }
        [JsonProperty("LA")]
        public InstrumentMarketDataValue Last { get; set; }
        [JsonProperty("SE")]
        public InstrumentMarketDataValue Settlement { get; set; }
        [JsonProperty("BI")]
        public InstrumentMarketDataValue[] Bids { get; set; }
        [JsonProperty("OF")]
        public InstrumentMarketDataValue[] Offers { get; set; }
        [JsonProperty("OI")]
        public InstrumentMarketDataValue OpenInterest { get; set; }
        [JsonProperty("CL")]
        public InstrumentMarketDataValue Close { get; set; }
        [JsonProperty("TV")]
        public decimal? Volume { get; set; }
        [JsonProperty("EV")]
        public decimal? EffectiveVolume { get; set; }
        [JsonProperty("NV")]
        public decimal? NominalVolume { get; set; }
        [JsonProperty("IV")]
        public decimal? IndexValue { get; set; }
        [JsonProperty("HI")]
        public decimal? High { get; set; }
        [JsonProperty("LO")]
        public decimal? Low { get; set; }

        public decimal CurrentPrice
        {
            get {
                var currentPrice = 0M;

                if (IndexValue != null)
                {
                    return IndexValue.Value;
                }

                if (Last != null)
                {
                    currentPrice = Last.Price.GetValueOrDefault();
                }
                else if (Close != null)
                {
                    currentPrice = Close.Price.GetValueOrDefault();
                }

                if (Bids != null && Bids.Length > 0)
                {
                    var maxBidPrice = Bids.Max(x => x.Price).GetValueOrDefault();

                    if (maxBidPrice > currentPrice)
                    {
                        currentPrice = maxBidPrice;
                    }
                }

                if (Offers != null && Offers.Length > 0)
                {
                    var minOfferPrice = Offers.Min(x => x.Price).GetValueOrDefault();

                    if (minOfferPrice < currentPrice)
                    {
                        currentPrice = minOfferPrice;
                    }
                }

                return currentPrice;
            }
        }

        public decimal ChangePercentage
        {
            get {
                if (Last.Price != null && Close.Price != null)
                {
                    return ((Last.Price.Value / Close.Price.Value) - 1);
                }

                return 0;
            }
        }
    }
}
