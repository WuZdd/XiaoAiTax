using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Converters;
using BM.XiaoAi.ApiClient.Enums;
using Newtonsoft.Json;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Request.Tax
{
    /// <summary>
    /// 税务相关请求模型，它是一个抽象类
    /// </summary>
    public abstract class TaxRequestModel : RequestModel
    {
        /// <summary>
        /// *扣缴单位纳税人识别号
        /// </summary>
        [ApiParameterName("nsrsbh")]
        public string NashuirenShibiehao { get; set; }

        /// <summary>
        /// *行政区划代码
        /// </summary>
        [ApiParameterName("areaid")]
        [JsonConverter(typeof(EnumValueStringConverter))]
        public Administrative AreaId { get; set; }

        /// <summary>
        /// 实名账号 预留字段
        /// </summary>
        [ApiParameterName("smzh")]
        public string ShimingZhanghao { get; set; }

        /// <summary>
        /// 实名密码
        /// </summary>
        [ApiParameterName("smmm")]
        public string ShimingMima { get; set; }

        /// <summary>
        /// *所得月份 例如：201708
        /// </summary>
        [ApiParameterName("sdyf")]
        public string SuodeYuefen { get; set; }

        /// <summary>
        /// 部门编号 分部门报送时必选
        /// </summary>
        [ApiParameterName("bmbh")]
        public string BumenBianhao { get; set; }

        /// <summary>
        /// *服务版本号 默认V2.0.000
        /// </summary>
        [ApiParameterName("ver")]
        public string Version { get; set; } = "V2.0.000";

        /// <summary>
        /// 主管税务机关登记序号id
        /// <para>
        /// 报验户：从事生产经营的纳税人临时到外县（市）从事生产经营活动的，需要向经营地税务机关依法纳税的企业
        /// </para>
        /// <para>
        /// 因为报验户存在一个税号对应多个主管税务机关ID。需要用户自己把主管税务机关ID传给平台。第一次是人员报送查询中获取。由用户选择。
        /// </para>
        /// </summary>
        [ApiParameterName("djxhid")]
        public string DengjiXuhaoId { get; set; }

        /// <summary>
        /// *申报密码
        /// <para>
        /// 如果是浙江用户，这里填入网税系统用户密码
        /// </para>
        /// </summary>
        [ApiParameterName("sbmm")]
        public string ShenbaoMima { get; set; }

    }
}
