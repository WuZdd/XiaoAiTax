using BM.XiaoAi.ApiClient.ApiParameterModels.Request.Auth;

namespace BM.XiaoAi.ApiClient
{
    /// <summary>
    /// 客户端设置
    /// </summary>
    public class ClientSettings
    {
        /// <summary>
        /// 客户端Id（小爱提供）
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// 客户端访问秘钥（小爱提供）
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// 生成获取Token请求模型
        /// </summary>
        /// <returns></returns>
        public GetTokenRequestModel CreateGetTokenRequestModel() 
        {
            return new GetTokenRequestModel
            {
                ClientId = ClientId,
                ClientSecret = ClientSecret
            };
        }
    }
}
