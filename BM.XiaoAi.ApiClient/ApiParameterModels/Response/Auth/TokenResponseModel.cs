using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Response.Auth
{
    /// <summary>
    /// Token响应模型
    /// </summary>
    public class TokenResponseModel : IBusinessResponseModel
    {
        /// <summary>
        /// 访问令牌
        /// <para>后续访问其他API必须要带的</para>
        /// </summary>
        [ApiParameterName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 刷新令牌
        /// <para>用于access_token过期时通过刷新重新获取access_token</para>
        /// </summary>
        [ApiParameterName("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 过期时间（单位：秒）
        /// </summary>
        [ApiParameterName("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// 令牌类型 例如：Bearer
        /// </summary>
        [ApiParameterName("token_type")]
        public string TokenType { get; set; }
    }
}
