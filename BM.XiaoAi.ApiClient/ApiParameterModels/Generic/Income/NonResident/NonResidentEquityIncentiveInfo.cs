using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Income.NonResident
{
    /// <summary>
    /// 非居民个人股权激励
    /// </summary>
    public class NonResidentEquityIncentiveInfo : NonResidentIncomeInfoBase
    {

        /// <summary>
        /// 适用公式
        /// <para>证照类型为居民身份证不能填写，若填写此项则收入额无需填写</para>
        /// </summary>
        [ApiParameterName("sygs")]
        public string ShiyongGongshi { get; set; }

        /// <summary>
        /// 本年累计股权激励（不含本月）
        /// </summary>
        [ApiParameterName("ljsre")]
        public decimal? LeijiShourue { get; set; }

        /// <summary>
        /// 本年累计已扣缴税额
        /// </summary>
        [ApiParameterName("ykjse")]
        public decimal? YiKoujiaoShuie { get; set; }
    }
}
