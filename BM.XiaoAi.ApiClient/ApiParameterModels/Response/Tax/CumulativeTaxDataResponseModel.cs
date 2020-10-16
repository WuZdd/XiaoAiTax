using BM.XiaoAi.ApiClient.ApiParameterModels.Generic;
using BM.XiaoAi.ApiClient.Attributes;
using System.Collections.Generic;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Response.Tax
{
    /// <summary>
    /// 累计算税数据查询响应模型
    /// </summary>
    public class CumulativeTaxDataResponseModel : IBusinessResponseModel
    {
        /// <summary>
        /// 算税任务受理ID
        /// <para>
        /// 和算税服务输出的一致，回调时客户系统通过该ID匹配
        /// </para>
        /// </summary>
        [ApiParameterName("accept_id")]
        public string AcceptId { get; set; }

        /// <summary>
        /// 返回带有累计算税数据的人员列表
        /// </summary>
        [ApiParameterName("rylb")]
        public List<PersonalNormalSalaryInfo> PersonnelNormalSalaryInfoList { get; set; }
    }
}
