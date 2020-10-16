using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Withholding
{
    /// <summary>
    /// 个人劳务报酬信息
    /// </summary>
    public class PersonalLaborIncomeInfo : PersonalIncomeInfoBase
    {
        /// <summary>
        /// 所得项目代码
        /// <para>
        /// 0401-一般劳务报酬所得 0499-其他劳务报酬所得
        /// </para>
        /// </summary>
        [ApiParameterName("sdxm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IncomeItem SuodeXiangmu { get; set; }

        /// <summary>
        /// 商业健康保险
        /// </summary>
        [ApiParameterName("syjkbx")]
        public decimal? ShangyeJiankangBaoxian { get; set; }

        /// <summary>
        /// 税延养老保险
        /// </summary>
        [ApiParameterName("syylbx")]
        public decimal? ShuiyanYanglaoBaoxian { get; set; }

        /// <summary>
        /// 允许扣除的税费
        /// </summary>
        /// <remarks>
        /// 填写按照个人所得税法及其他法律法规规定，实际可扣除的税费
        /// </remarks>
        [ApiParameterName("yxkcsf")]
        public decimal? YunxuKouchuShuifei { get; set; }

        /// <summary>
        /// 减除费用
        /// </summary>
        [ApiParameterName("jcfy")]
        public decimal? JianchuFeiyong { get; set; }

        /// <summary>
        /// 专项扣除合计
        /// </summary>
        [ApiParameterName("zxkchj")]
        public decimal? ZuanxiangKouchuHeji { get; set; }

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

        /// <summary>
        /// 已预交税额
        /// </summary>
        [ApiParameterName("ykjse")]
        public new decimal? LeijiYiKoujiaoShuie { get; set; }
    }
}
