using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic
{
    /// <summary>
    /// 人员算税结果
    /// </summary>
    public class PersonalTaxResult : PersonalBasicInfo
    {
        /// <summary>
        /// 应纳税所得额
        /// </summary>
        [ApiParameterName("ljynssde")]
        public decimal? YingNashuiSuodeE { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [ApiParameterName("sl")]
        public decimal? Shuilv { get; set; }

        /// <summary>
        /// 速算扣除数
        /// </summary>
        [ApiParameterName("sskcs")]
        public decimal? SusuanKouchuShu { get; set; }

        /// <summary>
        /// 应纳税额
        /// </summary>
        [ApiParameterName("ljynse")]
        public decimal? YingNashuie { get; set; }

        /// <summary>
        /// 减免税额
        /// </summary>
        [ApiParameterName("ljjmse")]
        public decimal? LeijiJianmianShuie { get; set; }

        /// <summary>
        /// 应扣缴税额
        /// </summary>
        [ApiParameterName("ljyingkjse")]
        public decimal? YingKoujiaoShuie { get; set; }

        /// <summary>
        /// 已预交税额
        /// </summary>
        [ApiParameterName("ljykjse")]
        public decimal? LeijiYiKoujiaoShuie { get; set; }

        /// <summary>
        /// 应补退税额
        /// </summary>
        [ApiParameterName("ybtse")]
        public decimal? YingButuiShuie { get; set; }

        /// <summary>
        /// 算税状态代码
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
