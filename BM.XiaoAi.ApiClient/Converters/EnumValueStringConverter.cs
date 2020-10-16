using Newtonsoft.Json;
using System;

namespace BM.XiaoAi.ApiClient.Converters
{
    /// <summary>
    /// 定义枚举值和字符串值转化
    /// </summary>
    public class EnumValueStringConverter : JsonConverter
    {
        /// <summary>
        /// 仅在Api内部有效
        /// </summary>
        public static bool InternalOnly { get; set; } = true;

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsEnum;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize(reader, objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (serializer.ContractResolver.GetType().Namespace != "WebApiClient.Defaults" && InternalOnly)
            {
                writer.WriteValue(value);
                return;
            }
            Type targetType = Enum.GetUnderlyingType(value.GetType());
            writer.WriteValue(Convert.ChangeType(value as ValueType, targetType).ToString());
        }
    }
}
