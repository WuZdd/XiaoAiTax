using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic
{
    /// <summary>
    /// 个人基本信息
    /// </summary>
    public class PersonalBasicInfo : ApiParameterModelBase
    {
        /// <summary>
        /// *证照类型
        /// </summary>
        [ApiParameterName("zzlx")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LicenseType LicenseType { get; set; }

        /// <summary>
        /// *证照号码
        /// </summary>
        [ApiParameterName("zzhm")]
        public string LicenseNumber { get; set; }

        /// <summary>
        /// *姓名
        /// </summary>
        [ApiParameterName("xm")]
        public string FullName { get; set; }
    }
}
