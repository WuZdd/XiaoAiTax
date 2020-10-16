using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Reduction
{
    /// <summary>
    /// 商业健康保险附表
    /// </summary>
    /// <remarks>
    /// 商业健康保险附表只适用于预扣预缴【工资薪金】和【劳务报酬】填写了[商业健康保险]数据的所得项目。附表中的[本期扣除金额]合计必须等于所得项目中填写的[商业健康保险]金额。
    /// </remarks>
    public class CommercialHealthInsuranceSchedule : PersonalBasicInfo
    {
        /// <summary>
        /// *税优识别码
        /// </summary>
        [ApiParameterName("sysbm")]
        public string ShuiyouShibiema { get; set; }

        /// <summary>
        /// *保单生效日期
        /// 格式严格限制 YYYY-MM-DD
        /// </summary>
        [ApiParameterName("bdsxrq")]
        public string BaodanShengxiaoRiqi { get; set; }

        /// <summary>
        /// *年度保费
        /// </summary>
        [ApiParameterName("ndbf")]
        public decimal NianduBaofei { get; set; }

        /// <summary>
        /// *月度保费
        /// </summary>
        [ApiParameterName("ydbf")]
        public decimal YueduBaofei { get; set; }

        /// <summary>
        /// 本期扣除金额
        /// </summary>
        [ApiParameterName("bqkcje")]
        public decimal BenqiKouchuJinE { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [ApiParameterName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [ApiParameterName("errorinfo")]
        public string ErrorInfo { get; set; }
    }
}
