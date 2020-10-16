using BM.XiaoAi.ApiClient.Enums;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Request
{
    /// <summary>
    /// 包含额外请求路径信息的请求模型接口
    /// </summary>
    public interface IExtraUriPathRequestModel
    {
    }

    /// <summary>
    /// 包含额外个税请求路径信息的请求模型接口
    /// </summary>
    public interface IExtraTaxUriPathRequestModel : IExtraUriPathRequestModel
    {
        /// <summary>
        /// *行政区划代码
        /// </summary>
        Administrative AreaId { get; set; }

        /// <summary>
        /// *纳税人识别号
        /// </summary>
        string NashuirenShibiehao { get; set; }

        /// <summary>
        /// *所得月份
        /// </summary>
        string SuodeYuefen { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        string BumenBianhao { get; set; }
    }
}
