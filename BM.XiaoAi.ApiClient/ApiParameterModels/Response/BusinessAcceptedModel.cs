using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Response
{
    /// <summary>
    /// 业务受理模型
    /// </summary>
    public class BusinessAcceptedModel : IBusinessResponseModel
    {
        /// <summary>
        /// 受理ID
        /// </summary>
        [ApiParameterName("accept_id")]
        public string AcceptId { get; set; }
    }
}
