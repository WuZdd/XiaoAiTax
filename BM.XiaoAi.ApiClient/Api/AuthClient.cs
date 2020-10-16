using BM.XiaoAi.ApiClient.ApiContract;
using BM.XiaoAi.ApiClient.ApiParameterModels.Request.Auth;
using BM.XiaoAi.ApiClient.ApiParameterModels.Response.Auth;
using System;
using System.Threading;
using WebApiClient;

namespace BM.XiaoAi.ApiClient.Api
{
    /// <summary>
    /// 权鉴相关请求
    /// </summary>
    public class AuthClient
    {
        public IAuthContract AuthContract { get; }

        /// <summary>
        /// 权鉴Client
        /// </summary>
        /// <param name="authContract"></param>
        public AuthClient(IAuthContract authContract) 
        {
            AuthContract = authContract ?? HttpApi.Resolve<IAuthContract>();
        }

        /// <summary>
        /// 获取token <see cref="IAuthContract.GetToken"/>
        /// </summary>
        /// <param name="requestModel"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public ITask<TokenResponseModel> GetToken(GetTokenRequestModel requestModel,
            TimeSpan? timeout = null, CancellationToken cancellationToken = default)
        {
            return AuthContract.GetToken(requestModel, timeout, cancellationToken);
        }


        /// <summary>
        /// 刷新token <see cref="IAuthContract.RefreshToken"/>
        /// </summary>
        /// <param name="requestModel"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public ITask<TokenResponseModel> RefreshToken(
            RefreshTokenRequestModel requestModel,
            TimeSpan? timeout = null, CancellationToken cancellationToken = default)
        {
            return AuthContract.RefreshToken(requestModel, timeout, cancellationToken);
        }

    }
}
