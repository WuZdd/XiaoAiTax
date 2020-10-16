using System.IO;

namespace BM.XiaoAi.ApiClient.Test
{
    public class TestBase
    {
        protected static string TokenSettingFilePath = 
            Path.GetDirectoryName(typeof(TestBase).Assembly.Location) + "/XiaoAiTokenSettings.json";

        static TestBase() 
        {
            XiaoAiGlobal.InitializeDefaultConfig(config =>
            {
                config.DefaultXiaoAiClientSettings = new ClientSettings
                {
                    ClientId = "122371433052508160",
                    ClientSecret = "976cdc4a9a9a42deacd0245f3a1e78d8"
                };

                config.DefaultXiaoAiTaxSettings = new TaxSettings
                {
                    ShuiHao = "91440190480003461X",
                    DengjiXuhao = "10117440190480003461",
                    ShenbaoMima = "Aa123456",
                    Administrative = Enums.Administrative.广东省
                };

                config.Test = true;
            });
        }
    }
}
