using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;
using Xunit;

namespace BM.XiaoAi.ApiClient.Test.Converters
{
    public class EnumMemberStringConverterTest
    {
        enum Enum1 
        {
            中国护照,
            [EnumMember(Value = "外国人工作许可证（A类）")]
            外国人工作许可证_A,
            [EnumMember(Value = "外国人工作许可证（B类）")]
            外国人工作许可证_B,
        }

        [Flags]
        enum Enum2
        {
            任职受雇 = 1,
            提供临时劳务 = 2,
            转让财产 = 4,
            从事投资和经营活动 = 8,
            其他 = 16
        }

        class TestClass
        {
            [JsonConverter(typeof(StringEnumConverter))]
            public Enum1 MyProperty { get; set; }
            [JsonConverter(typeof(StringEnumConverter))]
            public Enum2 MyProperty1 { get; set; }
        }

        [Fact]
        public void Serialize_Object_ReturnsEnumMemberString()
        {
            var test = new TestClass()
            {
                MyProperty = Enum1.外国人工作许可证_A,
                MyProperty1 = Enum2.任职受雇 | Enum2.转让财产 | Enum2.其他,
            };
            string str = JsonConvert.SerializeObject(test);

            Assert.Contains("\"外国人工作许可证（A类）\"", str);
            Assert.Contains("\"任职受雇, 转让财产, 其他\"", str);
        }

        [Fact]
        public void Deserialize_ObjectJsonStringWithEnumMemberString_ReturnsTrueEnum()
        {
            string str = "{\"MyProperty\":\"外国人工作许可证（B类）\",\"MyProperty1\":\"提供临时劳务, 从事投资和经营活动\"}";
            var test = JsonConvert.DeserializeObject<TestClass>(str);

            Assert.True(test.MyProperty == Enum1.外国人工作许可证_B);
            Assert.True(test.MyProperty1 == (Enum2.提供临时劳务 | Enum2.从事投资和经营活动));
        }
    }
}
