﻿using Newtonsoft.Json;
using Primary.Serialization;
using System.Linq;

namespace Primary.Data
{
    [JsonConverter(typeof(EntryJsonSerializer))]
    public enum Entry
    {
        Bids, 
        Offers,
        Last,
        Open,
        Close,
        SettlementPrice,
        SessionHighPrice,
        SessionLowPrice,
        Volume,
        OpenInterest,
        IndexValue,
        EffectiveVolume,
        NominalVolume
    } 

    #region String serialization

    internal static class EnumsToApiStrings
    {
        public const string AllEntryApiStrings = "BI,OF,LA,OP,CL,SE,OI,LO,HI,TV,NV,EV,IV";

        public static string ToApiString(this Entry value)
        {
            switch (value)
            {
                case Entry.Bids: return "BI";
                case Entry.Offers: return "OF";
                case Entry.Last: return "LA";
                case Entry.Open: return "OP";
                case Entry.Close: return "CL";
                case Entry.SettlementPrice: return "SE";
                case Entry.SessionHighPrice: return "HI";
                case Entry.SessionLowPrice: return "LO";
                case Entry.Volume: return "TV";
                case Entry.OpenInterest: return "OI";
                case Entry.IndexValue: return "IV";
                case Entry.EffectiveVolume: return "EV";
                case Entry.NominalVolume: return "NV";
                default: throw new InvalidEnumStringException( value.ToString() );
            }
        }

        public static string ToApiString(this Entry[] entries)
        {
            var entryList = entries.Select(x => ToApiString(x));
            var apiString = string.Join(',', entryList);
            return apiString;
        }

        public static Entry EntryFromApiString(string value)
        {
            switch (value)
            {
                case "BI": return Entry.Bids;
                case "OF": return Entry.Offers;
                case "LA": return Entry.Last;
                case "OP": return Entry.Open;
                case "CL": return Entry.Close;
                case "SE": return Entry.SettlementPrice;
                case "HI": return Entry.SessionHighPrice;
                case "LO": return Entry.SessionLowPrice;
                case "TV": return Entry.Volume;
                case "OI": return Entry.OpenInterest;
                case "IV": return Entry.IndexValue;
                case "EV": return Entry.EffectiveVolume;
                case "NV": return Entry.NominalVolume;
                default: throw new InvalidEnumStringException(value);
            }
        }
    }

    #endregion

    #region JSON Serialization

    public class EntryJsonSerializer : EnumJsonSerializer<Entry>
    {
        protected override string ToString(Entry enumValue)
        {
            return enumValue.ToApiString();
        }

        protected override Entry FromString(string enumString)
        {
            return EnumsToApiStrings.EntryFromApiString(enumString);
        }
    }

    #endregion
}
