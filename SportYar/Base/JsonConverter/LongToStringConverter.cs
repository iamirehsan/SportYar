using System.Text.Json;
using System.Text.Json.Serialization;

namespace SportYar.Base.JsonConverter
{
    public class LongToStringConverter : JsonConverter<long>
    {
        public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            long result = 0;
            try
            {
                result = reader.GetInt64();
            }
            catch (InvalidOperationException)
            {
                if (!long.TryParse(reader.GetString(), out result))
                {
                    throw;
                }
            }

            return result;
        }

        public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options) =>
            writer.WriteStringValue(value.ToString());
    }
}
