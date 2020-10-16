using BM.XiaoAi.ApiClient.ApiContract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using WebApiClient;

namespace BM.XiaoAi.ApiClient.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {

        public static void AddXiaoAiApiClient(this IServiceCollection services, Action<XiaoAiGlobalConfig> action = null)
        {
            services.AddSingleton(XiaoAiGlobal.GlobalConfig);
            action?.Invoke(XiaoAiGlobal.GlobalConfig);

            Action<HttpApiConfig> configAction = config =>
            {
                config.HttpHost = new Uri(XiaoAiGlobal.GlobalConfig.ApiUri);
                config.FormatOptions.IgnoreNullProperty = true;
                XiaoAiGlobal.GlobalConfig.ApiActionFilters.ToList().ForEach(filter => config.GlobalFilters.Add(filter));
                if (XiaoAiGlobal.GlobalConfig.UseLog)
                {
                    config.GlobalFilters.Add(new WebApiClient.Attributes.TraceFilterAttribute());
                }
                config.FormatOptions.DateTimeFormat = DateTimeFormats.ISO8601_WithMillisecond;
            };

            services.AddHttpApiFactory<IAuthContract>(configAction);
            services.AddHttpApiFactory<ITaxContract>(configAction);

            services.AddTransient<Api.AuthClient>();
            services.AddTransient<Api.TaxClient>();
        }

        /// <summary>
        /// HttpApi实例工厂创建器
        /// </summary>
        /// <param name="services"></param>
        private static void AddHttpApiFactory<TInterface>(this IServiceCollection services, Action<HttpApiConfig> configAction)
            where TInterface : class, IHttpApi
        {
            services.AddSingleton<IHttpApiFactory<TInterface>, HttpApiFactory<TInterface>>(p =>
            {
                return new HttpApiFactory<TInterface>()
                .ConfigureHttpApiConfig(c => configAction?.Invoke(c));
            });

            services.AddTransient(p =>
            {
                var factory = p.GetRequiredService<IHttpApiFactory<TInterface>>();
                return factory.CreateHttpApi();
            });
        }
    }
}
