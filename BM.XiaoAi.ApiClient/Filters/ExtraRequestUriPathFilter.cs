using BM.XiaoAi.ApiClient.ApiParameterModels.Request;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApiClient.Attributes;
using WebApiClient.Contexts;

namespace BM.XiaoAi.ApiClient.Filters
{
    /// <summary>
    /// 额外的请求路径
    /// </summary>
    public class ExtraRequestUriPathFilterAttribute : ApiActionFilterAttribute
    {

        public override Task OnBeginRequestAsync(ApiActionContext context)
        {
            this.AppendRequestUriPath(context);

            return Task.FromResult<object>(null);
        }

        /// <summary>
        /// 追加请求路径
        /// </summary>
        /// <param name="context"></param>
        /// <returns>请求上下文</returns>
        protected void AppendRequestUriPath(ApiActionContext context) 
        {
            IExtraTaxUriPathRequestModel requestModel = 
                context.ApiActionDescriptor.Arguments.FirstOrDefault(arg => arg is IExtraTaxUriPathRequestModel) as IExtraTaxUriPathRequestModel;

            if (requestModel != null)
            {
                var uriBuilder = new UriBuilder(context.RequestMessage.RequestUri);
                var extraPath = $"/{(int)requestModel.AreaId}/{requestModel.NashuirenShibiehao}/{requestModel.SuodeYuefen}";
                if (!string.IsNullOrEmpty(requestModel.BumenBianhao))
                {
                    extraPath += $"/{requestModel.BumenBianhao}";
                }
                uriBuilder.Path = uriBuilder.Path.Insert(uriBuilder.Path.Length, extraPath);

                context.RequestMessage.RequestUri = uriBuilder.Uri;
            }
        }
    }
}
