using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Withholding
{
    /// <summary>
    /// 个人稿酬信息
    /// </summary>
    public class PersonalRemunerationInfo : PersonalIncomeInfoBase
    {

        /// <summary>
        /// 减除费用
        /// </summary>
        [ApiParameterName("jcfy")]
        public decimal? JianchuFeiyong { get; set; }

        /// <summary>
        /// 费用
        /// </summary>
        [ApiParameterName("fy")]
        public decimal? Feiyong { get; set; }
    }
}
