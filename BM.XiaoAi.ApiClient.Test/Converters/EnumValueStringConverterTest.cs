using BM.XiaoAi.ApiClient.Converters;
using Newtonsoft.Json;
using Xunit;

namespace BM.XiaoAi.ApiClient.Test.Converters
{
    public class EnumValueStringConverterTest
    {
        public EnumValueStringConverterTest() 
        {
            EnumValueStringConverter.InternalOnly = false;
        }

        enum Enum1 : byte
        {
            A = 1,
            B = 2,
        }
        enum Enum2 : short
        {
            C = 3,
            D = 4,
        }
        enum Enum3
        {
            E = 5,
            F = 6,
        }

        class TestClass
        {
            [JsonConverter(typeof(EnumValueStringConverter))]
            public Enum1 MyProperty { get; set; }
            [JsonConverter(typeof(EnumValueStringConverter))]
            public Enum2 MyProperty1 { get; set; }
            [JsonConverter(typeof(EnumValueStringConverter))]
            public Enum3 MyProperty2 { get; set; }
        }

        [Fact]
        public void Serialize_Object_ReturnsStringEnumValue()
        {
            var test = new TestClass()
            {
                MyProperty = Enum1.A,
                MyProperty1 = Enum2.C,
                MyProperty2 = Enum3.E
            };
            var str = JsonConvert.SerializeObject(test);

            Assert.Contains("\"1\"", str);
            Assert.Contains("\"3\"", str);
            Assert.Contains("\"5\"", str);
        }

        [Fact]
        public void Deserialize_ObjectJsonStringWithStringEnumValue_ReturnsTrueEnum()
        {
            var str = "{\"MyProperty\":\"2\",\"MyProperty1\":\"4\",\"MyProperty2\":\"6\"}";
            var test = JsonConvert.DeserializeObject<TestClass>(str);

            Assert.True(test.MyProperty == Enum1.B);
            Assert.True(test.MyProperty1 == Enum2.D);
            Assert.True(test.MyProperty2 == Enum3.F);
        }
    }
}
