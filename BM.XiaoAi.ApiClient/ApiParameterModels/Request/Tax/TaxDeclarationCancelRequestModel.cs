using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Request.Tax
{
    /// <summary>
    /// 个税申报作废服务请求模型
    /// </summary>
    public class TaxDeclarationCancelRequestModel : TaxRequestModel, IExtraTaxUriPathRequestModel
    {

        /// <summary>
        /// 网税系统用户名 浙江用户特有
        /// </summary>
        [ApiParameterName("wsxtyhm")]
        public string WangshuiXitongYonghuming { get; set; }

        /// <summary>
        /// 报表类别 例如：[“SB0701”,” SB0703”]
        /// </summary>
        /// <remarks>
        /// SB0701：预扣预缴申报表；SB0702：分类所得申报表；SB0703：非居民申报表
        /// </remarks>
        [ApiParameterName("bblb")]
        public string[] BaobiaoLeibie { get; set; }

    }
}
