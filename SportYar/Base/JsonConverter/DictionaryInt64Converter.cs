using System.Text.Json;
using System.Text.Json.Serialization;

namespace SportYar.Base.JsonConverter
{
    public class DictionaryInt64Converter : JsonConverter<Dictionary<long, string>>
    {
        public override Dictionary<long, string> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            var value = new Dictionary<long, string>();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return value;
                }

                string keyString = reader.GetString();

                if (!long.TryParse(keyString, out long keyAsInt64))
                {
                    throw new JsonException($"Unable to convert \"{keyString}\" to System.Int64.");
                }

                reader.Read();

                string itemValue = reader.GetString();

                value.Add(keyAsInt64, itemValue);
            }

            throw new JsonException("Error Occured");
        }

        public override void Write(Utf8JsonWriter writer, Dictionary<long, string> value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            foreach (KeyValuePair<long, string> item in value)
            {
                writer.WriteString(item.Key.ToString(), item.Value);
            }

            writer.WriteEndObject();
        }
    }
}
