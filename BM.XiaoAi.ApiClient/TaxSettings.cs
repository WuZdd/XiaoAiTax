using BM.XiaoAi.ApiClient.Enums;

namespace BM.XiaoAi.ApiClient
{
    /// <summary>
    /// 报税设置
    /// </summary>
    public class TaxSettings
    {
        /// <summary>
        /// 税号
        /// </summary>
        public string ShuiHao { get; set; }

        /// <summary>
        /// 登记序号
        /// </summary>
        public string DengjiXuhao { get; set; }

        /// <summary>
        /// 申报密码
        /// </summary>
        public string ShenbaoMima { get; set; }

        /// <summary>
        /// 行政区划代码
        /// </summary>
        public Administrative Administrative { get; set; }
    }
}
