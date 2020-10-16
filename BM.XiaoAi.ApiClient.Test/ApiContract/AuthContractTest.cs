using BM.XiaoAi.ApiClient.ApiParameterModels.Request.Auth;
using BM.XiaoAi.ApiClient.ApiParameterModels.Response.Auth;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using WebApiClient;
using Xunit;

namespace BM.XiaoAi.ApiClient.Test.ApiContract
{
    public class AuthContractTest : TestBase
    {

        [Fact]
        public async Task GetToken_ReturnsTokenInfo()
        {
            var requestModel = XiaoAiGlobal.GlobalConfig.DefaultXiaoAiClientSettings.CreateGetTokenRequestModel();

            TokenResponseModel result = await ApiFactory.CreateAuthClient()
                .GetToken(requestModel)
                .Retry(3, TimeSpan.FromSeconds(2))
                .WhenCatch<HttpStatusFailureException>(ex => ex.StatusCode == System.Net.HttpStatusCode.RequestTimeout);

            Assert.NotNull(result);
            Assert.NotEmpty(result.AccessToken);

            WriteTokenSettings(result);
        }

        [Fact]
        public async Task RefreshToken_ReturnsTokenInfo()
        {
            if (!File.Exists(TokenSettingFilePath))
            {
                await GetToken_ReturnsTokenInfo();
            }

            var content = File.ReadAllText(TokenSettingFilePath);
            var tokenSettings = JsonConvert.DeserializeObject<TokenSettings>(content);

            var requestModel = new RefreshTokenRequestModel()
            {
                RefreshToken = tokenSettings.RefreshToken,
            };

            TokenResponseModel result = await ApiFactory.CreateAuthClient()
                .RefreshToken(requestModel)
                .Retry(3, TimeSpan.FromSeconds(2))
                .WhenCatch<HttpStatusFailureException>(ex => ex.StatusCode == System.Net.HttpStatusCode.RequestTimeout);

            Assert.NotNull(result);
            Assert.NotEmpty(result.AccessToken);

            WriteTokenSettings(result);
        }

        private void WriteTokenSettings(TokenResponseModel model)
        {
            var tokenSettings = new TokenSettings()
            {
                AccessToken = $"{model.TokenType} {model.AccessToken}",
                RefreshToken = model.RefreshToken,
                ExpiresIn = model.ExpiresIn
            };

            var output = JsonConvert.SerializeObject(tokenSettings);
            File.WriteAllText(TokenSettingFilePath, output);
        }
    }
}
