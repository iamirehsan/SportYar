using System.Text.Json;
using System.Text.Json.Serialization;

namespace SportYar.Base.JsonConverter
{
    public class IntToStringConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var result = 0;
            try
            {
                result = reader.GetInt32();
            }
            catch (InvalidOperationException)
            {
                if (!int.TryParse(reader.GetString(), out result))
                {
                    throw;
                }
            }

            return result;
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options) =>
            writer.WriteStringValue(value.ToString());
    }
}
