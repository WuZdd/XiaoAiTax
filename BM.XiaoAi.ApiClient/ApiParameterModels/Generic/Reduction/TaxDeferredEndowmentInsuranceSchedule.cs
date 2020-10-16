using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Reduction
{
    /// <summary>
    /// 税延型商业养老保险附表
    /// </summary>
    /// <remarks>
    /// 商业健康保险附表只适用于预扣预缴【工资薪金】和【劳务报酬】填写了[税延养老保险]数据的所得项目。附表中的[本期扣除金额]合计必须等于所得项目中填写的[税延养老保险]金额
    /// </remarks>
    public class TaxDeferredEndowmentInsuranceSchedule : PersonalBasicInfo
    {
        /// <summary>
        /// *税延养老账号编号
        /// </summary>
        [ApiParameterName("syylzhbh")]
        public string ShuiyanYanglaoZhanghaoBianhao { get; set; }

        /// <summary>
        /// *申报扣除月份起 格式严格限制YYYYMM
        /// </summary>
        [ApiParameterName("sbkcyf_q")]
        public string ShenbaoKouchuYuefen_Qi { get; set; }

        /// <summary>
        /// *申报扣除月份止 格式严格限制YYYYMM。月份止不能小于月份起
        /// </summary>
        [ApiParameterName("sbkcyf_z")]
        public string ShenbaoKouchuYuefen_Zhi { get; set; }

        /// <summary>
        /// *报税校验码
        /// </summary>
        [ApiParameterName("bsjym")]
        public string BaoshuiJiaoyanma { get; set; }

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
