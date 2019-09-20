using Newtonsoft.Json;
using Primary.Data.Serialization;
using System;
using System.Diagnostics;

namespace Primary.Data
{
    [DebuggerDisplay("{Price.GetValueOrDefault().ToString(\"C\")} {Size.GetValueOrDefault().ToString(\"C0\")}")]
    public class InstrumentMarketDataValue
    {
        [JsonProperty("price")]
        public decimal? Price { get; set; }
        [JsonProperty("size")]
        public decimal? Size { get; set; }
        [JsonProperty("date")]
        [JsonConverter(typeof(UnixTimeMillisecondsConverter))]
        public DateTime? Date { get; set; }
    }
}
