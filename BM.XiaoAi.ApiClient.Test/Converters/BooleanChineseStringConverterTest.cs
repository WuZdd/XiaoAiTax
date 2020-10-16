using BM.XiaoAi.ApiClient.Converters;
using Newtonsoft.Json;
using Xunit;

namespace BM.XiaoAi.ApiClient.Test.Converters
{
    public class BooleanChineseStringConverterTest
    {
        public BooleanChineseStringConverterTest() 
        {
            BooleanChineseStringConverter.InternalOnly = false;   
        }

        class TestClass 
        {
            [JsonConverter(typeof(BooleanChineseStringConverter))]
            public bool MyProperty { get; set; }

            [JsonConverter(typeof(BooleanChineseStringConverter))]
            public bool? MyProperty1 { get; set; }
        }

        [Fact]
        public void Serialize_Test() 
        {
            var test = new TestClass
            {
                MyProperty = true,
                MyProperty1 = false,
            };
            var str = JsonConvert.SerializeObject(test);

            Assert.Contains("\"是\"", str);
            Assert.Contains("\"否\"", str);
        }

        [Fact]
        public void Deserialize_Test()
        {
            var str = "{\"MyProperty\":\"是\",\"MyProperty1\":\"否\"}";
            var test = JsonConvert.DeserializeObject<TestClass>(str);

            Assert.True(test.MyProperty);
            Assert.False(test.MyProperty1);
        }
    }
}
