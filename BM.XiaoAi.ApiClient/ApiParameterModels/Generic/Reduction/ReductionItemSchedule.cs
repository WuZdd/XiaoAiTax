using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Reduction
{
    /// <summary>
    /// 减免事项附表
    /// </summary>
    /// <remarks>
    /// 减免事项附表适用于预扣预缴、分类所得、非居民收入，只要所得项目中填写了[减免税额]或[免税收入]项数据，就必须有对应的减免事项附表与之对应。<para />
    /// 并满足如下条件：减免方式为减免税额的所有附表的[减免金额]合计=所得项目中填写的[减免税额]；减免方式为免税收入的所有附表的[减免金额]合计=所得项目中填写的[免税收入]。
    /// </remarks>
    public class ReductionItemSchedule : PersonalBasicInfo
    {
        /// <summary>
        /// *减免方式 0-减免税额；1-免税收入
        /// </summary>
        [ApiParameterName("jmfs")]
        public int JianmianFangshi { get; set; }

        /// <summary>
        /// *所得项目代码
        /// </summary>
        [ApiParameterName("sdxm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IncomeItem SuodeXiangmu { get; set; }

        /// <summary>
        /// *减免事项 见《减免事项字典》
        /// </summary>
        [ApiParameterName("jmsx")]
        public string JianmianShixiang { get; set; }

        /// <summary>
        /// *减免性质 见《减免事项字典》
        /// </summary>
        [ApiParameterName("jmxz")]
        public string JianmianXingzhi { get; set; }

        /// <summary>
        /// 减免税额/免税收入
        /// </summary>
        [ApiParameterName("jmje")]
        public decimal JianmianJinE { get; set; }

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
