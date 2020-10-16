using Newtonsoft.Json;
using System;

namespace BM.XiaoAi.ApiClient.Converters
{
    /// <summary>
    /// 定义布尔值和中文字符转化
    /// </summary>
    public class BooleanChineseStringConverter : JsonConverter
    {
        public const string CHINESE_CHARACTER_TRUE = "是";

        public const string CHINESE_CHARACTER_FALSE = "否";

        /// <summary>
        /// 仅在Api内部有效
        /// </summary>
        public static bool InternalOnly { get; set; } = true;

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(bool);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (serializer.ContractResolver.GetType().Namespace != "WebApiClient.Defaults" && InternalOnly
                && reader.TokenType != JsonToken.String)
            {
                return serializer.Deserialize(reader, objectType);
            }

            return CHINESE_CHARACTER_TRUE.Equals(reader.Value);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (serializer.ContractResolver.GetType().Namespace != "WebApiClient.Defaults" && InternalOnly)
            {
                writer.WriteValue(value);
                return;
            }

            writer.WriteValue(((bool)value) ? CHINESE_CHARACTER_TRUE : CHINESE_CHARACTER_FALSE);
        }
    }
}
