﻿using System.Linq;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class TextualIntegerArrayWithCommaConverter : JsonConverter<int[]?>
    {
        private const char SEPARATOR = ',';

        public override int[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                string? value = reader.GetString();
                if (value == null)
                    return null;

                return value.Split(new char[] { SEPARATOR }, StringSplitOptions.RemoveEmptyEntries).Select(e => int.Parse(e)).ToArray();
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, int[]? value, JsonSerializerOptions options)
        {
            if (value != null)
                writer.WriteStringValue(string.Join(SEPARATOR.ToString(), value));
            else
                writer.WriteNullValue();
        }
    }
}
