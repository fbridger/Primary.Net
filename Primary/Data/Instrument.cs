using Newtonsoft.Json;

namespace Primary.Data
{
    /// <summary>Identifies a market instrument.</summary>
    public class Instrument
    {
        public const string MervalPrefix = "MERV - XMEV - ";

        /// <summary>Market where the instruments belongs to.</summary>
        /// <remarks>Only accepted value is **ROFX**.</remarks>
        [JsonProperty("marketId")]
        public string Market { get; set; }

        /// <summary>Ticker of the instrument.</summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        public string SymbolWithoutPrefix()
        {
            if (Symbol.StartsWith(MervalPrefix))
            {
                return Symbol.Substring(MervalPrefix.Length).Trim();
            }
            return Symbol;
        }

        public string Ticker()
        {
            if (Symbol.StartsWith(MervalPrefix))
            {
                int tickerLength = Symbol.LastIndexOf('-') - MervalPrefix.Length;
                if (tickerLength > 0)
                {
                    return Symbol.Substring(MervalPrefix.Length, tickerLength).Trim();
                }
                return Symbol.Substring(MervalPrefix.Length).Trim();
            }
            return Symbol;
        }

        public string SettlementTerm()
        {
            if (Symbol.StartsWith(MervalPrefix))
            {
                if (Symbol.LastIndexOf('-') > MervalPrefix.Length)
                {
                    return Symbol.Substring(Symbol.LastIndexOf('-')).Trim();
                }
            }
            return string.Empty;

        }
    }
}
