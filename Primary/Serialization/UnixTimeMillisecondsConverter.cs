using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Primary.Data.Serialization
{
    public class UnixTimeMillisecondsConverter : DateTimeConverterBase
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue(UnixTimeMillisecondsFromDateTime((DateTime)value).ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null) { return null; }
            return DateTimeFromUnixTimeMilliseconds((long)reader.Value);
        }

        public static DateTime DateTimeFromUnixTimeMilliseconds(long unixTimestamp)
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(unixTimestamp).LocalDateTime;
        }

        public static long UnixTimeMillisecondsFromDateTime(DateTime date)
        {
            return new DateTimeOffset(date).ToUnixTimeMilliseconds();
        }
    }
}
