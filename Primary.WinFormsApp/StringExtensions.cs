using Primary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary.WinFormsApp
{
    public static class InstrumentExtensions
    {
        public static IEnumerable<Instrument> FilterByTicker(this IEnumerable<Instrument> instruments, string ticker)
        {
            var tickerSymbols = ticker.GetAllSymbols();
            return instruments.Where(x => tickerSymbols.Contains(x.Symbol));
        }
    }

    public static class TradeExtensions
    {
        public static string ToReadableBook(this Entries entries)
        {
            var sb = new StringBuilder();
            var length = entries.Bids.Length > entries.Offers.Length ? entries.Bids.Length : entries.Offers.Length;
            for (int i = 0; i < length; i++)
            {
                if (entries.Bids.Length > i && entries.Offers.Length > i)
                {
                    sb.AppendLine(entries.Bids[i].ToReadableBid() + "\t - \t" + entries.Offers[i].ToReadableOffer());
                }
                else if (entries.Bids.Length > i)
                {
                    sb.AppendLine(entries.Bids[i].ToReadableBid() + "\t - \t");
                }
                else if (entries.Offers.Length > i)
                {
                    sb.AppendLine("\t - \t" + entries.Offers[i].ToReadableOffer());
                }

            }
            return sb.ToString();
        }

        public static string ToReadableBids(this Entries entries)
        {
            var bid = new StringBuilder();
            foreach (var item in entries.Bids)
            {
                bid.AppendLine(item.ToReadableBid());
            }
            return bid.ToString();
        }
        public static string ToReadableOffers(this Entries entries)
        {
            var offer = new StringBuilder();
            foreach (var item in entries.Offers)
            {
                offer.AppendLine(item.ToReadableOffer());
            }
            return offer.ToString();
        }


        public static string ToReadableBid(this Trade trade)
        {
            return $"{trade.Size:#,###} x {trade.Price:C}";
        }

        public static string ToReadableOffer(this Trade trade)
        {
            return $"{trade.Price:C} x {trade.Size:#,###}";
        }

        public static string ToUSD(this decimal value)
        {
            return value.ToString("USD #,##0.00");
        }

        public static string ToCurrency(this decimal value)
        {
            return value.ToString("C2");
        }
    }

    public static class StringExtensions
    {
        public const string DolarSuffix = "D";
        public const string CableSuffix = "C";
        public const string Settlement48H = "48hs";
        public const string Settlement24H = "24hs";
        public const string SettlementCI = "CI";

        public static string[] AllSettlements = new[] { Settlement48H, Settlement24H, SettlementCI };

        public static string AddDolarSuffix(this string ticker)
        {
            return $"{ticker}D";
        }

        public static string AddCableSuffix(this string ticker)
        {
            return $"{ticker}C";
        }

        public static string ToMervalSymbol48H(this string ticker)
        {
            return ticker.ToMervalSymbol(Settlement48H);
        }
        public static string ToMervalSymbol24H(this string ticker)
        {
            return ticker.ToMervalSymbol(Settlement24H);
        }
        public static string ToMervalSymbolCI(this string ticker)
        {
            return ticker.ToMervalSymbol(SettlementCI);
        }

        public static string ToMervalSymbol(this string ticker, string settlement)
        {
            return Instrument.MervalPrefix + $"{ticker} - {settlement}";
        }

        public static string[] GetAllSymbols(this string ticker)
        {
            var tickerD = ticker.AddDolarSuffix();
            var tickerC = ticker.AddCableSuffix();

            return new[] {
                ticker.ToMervalSymbol48H(),
                ticker.ToMervalSymbol24H(),
                ticker.ToMervalSymbolCI(),
                tickerD.ToMervalSymbol48H(),
                tickerD.ToMervalSymbol24H(),
                tickerD.ToMervalSymbolCI(),
                tickerC.ToMervalSymbol48H(),
                tickerC.ToMervalSymbol24H(),
                tickerC.ToMervalSymbolCI()
            };
        }

        public static string[] GetAllSettlements(this string ticker)
        {
            return new[] {
                ticker.ToMervalSymbol48H(),
                ticker.ToMervalSymbol24H(),
                ticker.ToMervalSymbolCI()
            };
        }
    }
}
