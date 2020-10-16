using BM.XiaoAi.ApiClient.ApiParameterModels.Request.Auth;
using BM.XiaoAi.ApiClient.ApiParameterModels.Response.Auth;
using System;
using System.Threading;
using WebApiClient;
using WebApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiContract
{
    /// <summary>
    /// 权鉴相关接口
    /// </summary>
    public interface IAuthContract : IHttpApi
    {

        /// <summary>
        /// 获取token
        /// </summary>
        /// <returns></returns>
        [Timeout(5 * 1000)]
        [HttpPost("uaa/v1/auth/tokens")]
        [JsonReturn]
        ITask<TokenResponseModel> GetToken(
            [JsonContent] GetTokenRequestModel requestModel,
            [Timeout] TimeSpan? timeout = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// 刷新token
        /// </summary>
        /// <returns></returns>
        [Timeout(5 * 1000)]
        [HttpPost("uaa/v1/auth/tokens")]
        [JsonReturn]
        ITask<TokenResponseModel> RefreshToken(
            [JsonContent] RefreshTokenRequestModel requestModel,
            [Timeout] TimeSpan? timeout = null, CancellationToken cancellationToken = default);
    }
}
