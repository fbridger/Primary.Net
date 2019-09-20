using Newtonsoft.Json;

namespace Primary.Data
{
    internal class InstrumentMarketDataResponse
    {
        [JsonProperty("status")]
        public string Status;

        [JsonProperty("message")]
        public string Message;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("marketData")]
        public InstrumentMarketData MarketData;

        [JsonProperty("depth")]
        public int Depth;

        [JsonProperty("aggregated")]
        public bool Aggregated;
    }
}
