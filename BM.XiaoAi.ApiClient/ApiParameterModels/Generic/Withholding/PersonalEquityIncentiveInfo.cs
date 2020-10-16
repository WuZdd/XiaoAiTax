using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Withholding
{
    /// <summary>
    /// 个人股权激励收入信息
    /// </summary>
    public class PersonalEquityIncentiveInfo : PersonalIncomeInfoBase
    {

        /// <summary>
        /// 适用公式
        /// <para>
        /// 证照类型为居民身份证不能填写，若填写此项则收入额无需填写
        /// </para>
        /// </summary>
        [ApiParameterName("sygs")]
        public string ShiyongGongshi { get; set; }

        /// <summary>
        /// 境内工作天数
        /// </summary>
        [ApiParameterName("jnts")]
        public decimal JingneiTianshu { get; set; }

        /// <summary>
        /// 境外工作天数
        /// </summary>
        [ApiParameterName("jwts")]
        public decimal JingwaiTianshu { get; set; }

        /// <summary>
        /// 境内支付
        /// </summary>
        [ApiParameterName("jnzf")]
        public decimal JingneiZhifu { get; set; }

        /// <summary>
        /// 境外支付
        /// </summary>
        [ApiParameterName("jwzf")]
        public decimal JingwaiZhifu { get; set; }

        /// <summary>
        /// 本年累计股权激励（不含本月）
        /// </summary>
        [ApiParameterName("ljsre")]
        public decimal LeijiShourue { get; set; }

        /// <summary>
        /// 本年累计准予扣除的捐赠额
        /// </summary>
        [ApiParameterName("zykcdjze")]
        public decimal? ZhunyuKouchuJuanzengE { get; set; }
    }
}
