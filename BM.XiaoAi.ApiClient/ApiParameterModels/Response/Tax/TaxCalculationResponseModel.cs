using BM.XiaoAi.ApiClient.ApiParameterModels.Request.Tax;
using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Response.Tax
{
    /// <summary>
    /// 税款计算查询服务响应模型
    /// </summary>
    public class TaxCalculationResponseModel : IncomeData, IBusinessResponseModel
    {

        /// <summary>
        /// 算税任务受理ID
        /// <para>
        /// 和算税服务输出的一致，回调时客户系统通过该ID匹配
        /// </para>
        /// </summary>
        [ApiParameterName("accept_id")]
        public string AcceptId { get; set; }

    }
}
