using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Response
{
    public class Response<T> : ResponseModel where T : class, IBusinessResponseModel
    {
        /// <summary>
        /// 业务返回内容
        /// </summary>
        [ApiParameterName("data")]
        public T BusinessResponseContent { get; set; }

        /// <summary>
        /// 存在有效的业务响应
        /// </summary>
        public bool ExistsBusinessResponseContent { get => this.BusinessResponseContent != null; }
    }
}
