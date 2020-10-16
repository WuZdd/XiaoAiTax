using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Income.NonResident
{
    /// <summary>
    /// 非居民正常工资薪金
    /// </summary>
    public class NonResidentNormalSalaryInfo : NonResidentIncomeInfoBase
    {
        /// <summary>
        /// 适用公式
        /// <para>证照类型为居民身份证不能填写，若填写此项则收入额无需填写</para>
        /// </summary>
        [ApiParameterName("sygs")]
        public string ShiyongGongshi { get; set; }

    }
}
