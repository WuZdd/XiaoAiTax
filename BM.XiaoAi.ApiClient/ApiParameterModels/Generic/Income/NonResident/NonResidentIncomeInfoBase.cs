using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Income.NonResident
{
    /// <summary>
    /// 非居民所得信息基类
    /// </summary>
    public abstract class NonResidentIncomeInfoBase : PersonalIncomeInfoBase
    {
        /// <summary>
        /// 境内工作天数
        /// </summary>
        [ApiParameterName("jnts")]
        public decimal? JingneiTianshu { get; set; }

        /// <summary>
        /// 境外工作天数
        /// </summary>
        [ApiParameterName("jwts")]
        public decimal? JingwaiTianshu { get; set; }

        /// <summary>
        /// 境内支付
        /// </summary>
        [ApiParameterName("jnzf")]
        public decimal? JingneiZhifu { get; set; }

        /// <summary>
        /// 境外支付
        /// </summary>
        [ApiParameterName("jwzf")]
        public decimal? JingwaiZhifu { get; set; }

        /// <summary>
        /// 实际捐赠额
        /// </summary>
        [ApiParameterName("sjjze")]
        public decimal? ShijiJuanzengE { get; set; }

        /// <summary>
        /// 捐赠方式
        /// <para>[限额扣除]/[全额扣除]/混合。默认[限额扣除]</para>
        /// </summary>
        [ApiParameterName("jzlx")]
        public string JuanzengFangshi { get; set; }

        /// <summary>
        /// 准予扣除捐赠额
        /// <para>【捐赠方式】填混合时，该字段可填写，否则填写无效</para>
        /// </summary>
        [ApiParameterName("zykcjze")]
        public decimal? ZhunyuKouchuJuanzengE { get; set; }

        /// <summary>
        /// 应纳税所得额
        /// </summary>
        [ApiParameterName("ynssde")]
        public new decimal? YingNashuiSuodeE { get; set; }

        /// <summary>
        /// 应纳税额
        /// </summary>
        [ApiParameterName("ynse")]
        public new decimal? YingNashuie { get; set; }

        /// <summary>
        /// 应扣缴税额
        /// </summary>
        [ApiParameterName("yingkjse")]
        public new decimal? YingKoujiaoShuie { get; set; }
    }
}
