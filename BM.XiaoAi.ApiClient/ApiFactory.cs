using BM.XiaoAi.ApiClient.Api;

namespace BM.XiaoAi.ApiClient
{
    /// <summary>
    /// Api静态工厂
    /// </summary>
    public static class ApiFactory
    {
        /// <summary>
        /// 创建权鉴相关Client
        /// </summary>
        /// <returns></returns>
        public static AuthClient CreateAuthClient() => new AuthClient(null);

        /// <summary>
        /// 创建个税相关Client
        /// </summary>
        /// <returns></returns>
        public static TaxClient CreateTaxClient() => new TaxClient(null);
    }
}
