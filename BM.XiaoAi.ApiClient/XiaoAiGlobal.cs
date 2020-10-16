using System;
using System.Linq;
using WebApiClient;

namespace BM.XiaoAi.ApiClient
{
    public static class XiaoAiGlobal
    {
        /// <summary>
        /// 静态的全局配置信息
        /// </summary>
        public static XiaoAiGlobalConfig GlobalConfig { get; set; } = new XiaoAiGlobalConfig();

        /// <summary>
        /// 初始化全局配置
        /// <para>在没有DI的情况下可以使用它来初始化配置</para>
        /// </summary>
        /// <param name="action"></param>
        public static void InitializeDefaultConfig(Action<XiaoAiGlobalConfig> action) 
        {
            action.Invoke(GlobalConfig);

            Action<HttpApiConfig> configAction = config =>
            {
                config.HttpHost = new Uri(GlobalConfig.ApiUri);
                config.FormatOptions.IgnoreNullProperty = true;
                GlobalConfig.ApiActionFilters.ToList().ForEach(filter => config.GlobalFilters.Add(filter));
                if (GlobalConfig.UseLog)
                {
                    config.GlobalFilters.Add(new WebApiClient.Attributes.TraceFilterAttribute() { OutputTarget = WebApiClient.Attributes.OutputTarget.Console });
                }
                config.FormatOptions.DateTimeFormat = DateTimeFormats.ISO8601_WithMillisecond;
            };

            HttpApi.Register<ApiContract.IAuthContract>().ConfigureHttpApiConfig(configAction);
            HttpApi.Register<ApiContract.ITaxContract>().ConfigureHttpApiConfig(configAction);
        }
    }
}
