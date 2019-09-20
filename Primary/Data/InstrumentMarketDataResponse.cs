using Newtonsoft.Json;

namespace Primary.Data
{
    internal class InstrumentMarketDataResponse
    {
        [JsonProperty("status")]
        public System.Net.HttpStatusCode Status;

        [JsonProperty("marketData")]
        public InstrumentMarketData MarketData;

        [JsonProperty("depth")]
        public int Depth;

        [JsonProperty("aggregated")]
        public bool Aggregated;
    }
}
