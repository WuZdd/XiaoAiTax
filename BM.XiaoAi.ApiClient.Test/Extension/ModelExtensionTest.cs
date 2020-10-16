using BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Income;
using BM.XiaoAi.ApiClient.Extension;
using Xunit;

namespace BM.XiaoAi.ApiClient.Test.Extension
{
    public class ModelExtensionTest
    {
        [Fact]
        public void NameOfApiParameter() 
        {
            var model = new PersonalIncidentalIncomeInfo();
            var apiParameterName = model.NameOfApiParameter(t => t.YingNashuie);

            Assert.True(apiParameterName == "ynse");
        }
    }
}
