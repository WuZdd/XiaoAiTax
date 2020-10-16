using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Request.Auth
{
    public class RefreshTokenRequestModel : RequestModel
    {
        /// <summary>
        /// 固定值 refresh_token
        /// </summary>
        [ApiParameterName("grant_type")]
        public string GrantType { get; set; } = "refresh_token";

        /// <summary>
        /// 刷新token 获取token时一并获取的 <see cref="ApiContract.IAuthContract.GetToken"/>
        /// </summary>
        [ApiParameterName("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
