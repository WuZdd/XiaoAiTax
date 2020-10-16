using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Request.Auth
{
    /// <summary>
    /// 获取令牌请求模型
    /// </summary>
    public class GetTokenRequestModel : RequestModel
    {
        /// <summary>
        /// 固定值 client_credential
        /// </summary>
        [ApiParameterName("grant_type")]
        public string GrantType { get; set; } = "client_credential";

        /// <summary>
        /// 客户端ID
        /// </summary>
        [ApiParameterName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 客户端访问秘钥
        /// </summary>
        [ApiParameterName("client_secret")]
        public string ClientSecret { get; set; }
    }
}
