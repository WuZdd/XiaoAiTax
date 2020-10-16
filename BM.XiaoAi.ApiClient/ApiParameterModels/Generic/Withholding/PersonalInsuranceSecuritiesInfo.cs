using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Withholding
{
    /// <summary>
    /// 个人保险、债券劳务报酬信息
    /// </summary>
    /// <remarks>
    /// 上期累计收入、上期累计费用、上期累计免税收入均不包含本期 <para/>
    /// 累计减除费用、其他扣除合计、累计准予扣除捐赠额、累计减免税额为包含本期的累计值
    /// </remarks>
    public class PersonalInsuranceSecuritiesInfo : PersonalIncomeInfoBase
    {
        /// <summary>
        /// 所得项目代码
        /// <para>
        /// 0402-保险营销员劳务报酬所得 0403-证券经纪人劳务报酬所得
        /// </para>
        /// </summary>
        [ApiParameterName("sdxm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IncomeItem SuodeXiangmu { get; set; }

        /// <summary>
        /// 商业健康保险
        /// <para>如填写该项数据，需要填写商业健康保险附表</para>
        /// </summary>
        [ApiParameterName("syjkbx")]
        public decimal? ShangyeJiankangBaoxian { get; set; }

        /// <summary>
        /// 税延养老保险
        /// <para>如填写该项数据，需要填写税延养老保险附表</para>
        /// </summary>
        [ApiParameterName("syylbx")]
        public decimal? ShuiyanYanglaoBaoxian { get; set; }

        /// <summary>
        /// 允许扣除税费
        /// </summary>
        [ApiParameterName("yxkcsf")]
        public decimal? YunxuKouchuShuifei { get; set; }

        /// <summary>
        /// 费用 <para>= 本期收入 * 20%</para> 
        /// </summary>
        [ApiParameterName("fy")]
        public decimal? Feiyong { get; set; }

        /// <summary>
        /// 展业成本 <para>=（本期收入 - 费用）* 25%</para>
        /// </summary>
        [ApiParameterName("zycb")]
        public decimal? ZhanyeChengben { get; set; }

        /// <summary>
        /// 减除费用 <para>= 5000元/月</para>
        /// </summary>
        [ApiParameterName("jcfy")]
        public decimal? JianchuFeiyong { get; set; }

        /// <summary>
        /// 上期累计收入
        /// </summary>
        [ApiParameterName("ljsre")]
        public decimal? LeijiShourue { get; set; }

        /// <summary>
        /// 上期累计费用
        /// </summary>
        [ApiParameterName("ljfy")]
        public decimal? LeijiFeiyong { get; set; }

        /// <summary>
        /// 上期累计免税收入
        /// </summary>
        [ApiParameterName("ljmssd")]
        public decimal? LeijiMianshuiSuode { get; set; }

        /// <summary>
        /// 累计减除费用
        /// </summary>
        [ApiParameterName("ljjcfy")]
        public decimal? LeijiJianchuFeiyong { get; set; }

        /// <summary>
        /// 累计准予扣除捐赠额
        /// </summary>
        [ApiParameterName("ljzykcjze")]
        public decimal? LeijiZhunyuKouchuJuanzengE { get; set; }

        /// <summary>
        /// 专项扣除合计
        /// </summary>
        [ApiParameterName("zxkchj")]
        public decimal? ZhuanxiangKouchuHeji { get; set; }

        /// <summary>
        /// 其他扣除合计
        /// </summary>
        [ApiParameterName("qtckhj")]
        public decimal? QitaKouchuHeji { get; set; }

        /// <summary>
        /// 专项附加扣除合计
        /// </summary>
        [ApiParameterName("zxfjkchj")]
        public decimal? ZhuanxiangFujiaKouchuHeji { get; set; }

        /// <summary>
        /// 扣除项目合计
        /// </summary>
        [ApiParameterName("kcxmhj")]
        public decimal? KouchuXiangmuHeji { get; set; }
    }
}
