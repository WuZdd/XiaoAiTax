using System.Collections.Generic;
using WebApiClient;

namespace BM.XiaoAi.ApiClient
{
    /// <summary>
    /// 小爱全局配置
    /// </summary>
    public class XiaoAiGlobalConfig
    {
        /// <summary>
        /// 生产环境Uri
        /// </summary>
        public string ProductionEnvironmentApiUri { get; set; } = "https://api.workai.com.cn/";

        /// <summary>
        /// 测试环境Uri
        /// </summary>
        public string TestingEnvironmentApiUri { get; set; } = "http://118.178.181.180:20000/";

        /// <summary>
        /// 使用测试环境，默认false
        /// </summary>
        public bool Test { get; set; } = false;

        /// <summary>
        /// Api地址
        /// </summary>
        public string ApiUri { get => Test ? TestingEnvironmentApiUri : ProductionEnvironmentApiUri; }

        /// <summary>
        /// 默认的小爱客户端配置
        /// </summary>
        public ClientSettings DefaultXiaoAiClientSettings { get; set; }

        /// <summary>
        /// 默认的小爱报税配置
        /// </summary>
        public TaxSettings DefaultXiaoAiTaxSettings { get; set; }

        /// <summary>
        /// 启用日志，默认false
        /// <para>
        /// 将会在日志中记录请求内容
        /// </para>
        /// </summary>
        public bool UseLog { get; set; } = false;

        /// <summary>
        /// 全局拦截器集合
        /// </summary>
        public List<IApiActionFilter> ApiActionFilters { get; set; } = new List<IApiActionFilter>();
    }
}
