using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Primary.Data.Serialization
{
    public class UnixTimeSecondsConverter : DateTimeConverterBase
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var text = UnixTimeSecondsFromDateTime((DateTime)value).ToString();
            writer.WriteRawValue(text);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
                return null;
            return DateTimeFromUnixTimeSeconds((long)reader.Value);
        }

        public static DateTime DateTimeFromUnixTimeSeconds(long unixTimestamp)
        {
            var dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
            return dateTimeOffset.LocalDateTime;
        }

        public static long UnixTimeSecondsFromDateTime(DateTime date)
        {
            var dateTimeOffset = new DateTimeOffset(date);
            return dateTimeOffset.ToUnixTimeSeconds();
        }
    }
}
