using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Income.NonResident
{
    /// <summary>
    /// 非居民劳务报酬
    /// </summary>
    public class NonResidentLaborIncomeInfo : NonResidentIncomeInfoBase
    {
        /// <summary>
        /// *所得项目代码
        /// </summary>
        /// <remarks>
        /// <list type="table">
        /// <item>0401-一般劳务报酬所得</item>
        /// <item>0402-保险营销员劳务报酬所得</item>
        /// <item>0403-证券经纪人劳务报酬所得</item>
        /// <item>0499-其他劳务报酬所得</item>
        /// </list>
        /// </remarks>
        [ApiParameterName("sdxm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IncomeItem SuodeXiangmu { get; set; }

        /// <summary>
        /// 允许扣除的税费
        /// <para>填写按照个人所得税法及其他法律法规规定，实际可扣除的税费</para>
        /// </summary>
        [ApiParameterName("yxkcsf")]
        public decimal? YunxuKouchuShuifei { get; set; }
    }
}
