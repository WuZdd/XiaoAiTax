using BM.XiaoAi.ApiClient.Attributes;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace BM.XiaoAi.ApiClient.Extension
{
    /// <summary>
    /// 模型扩展方法
    /// </summary>
    static public class ModelExtension
    {
        /// <summary>
        /// 获取属性在接口交互时对应的参数名
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="source"></param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static string NameOfApiParameter<TSource, TKey>(this TSource source, Expression<Func<TSource, TKey>> keySelector)
            where TSource : BM.XiaoAi.ApiClient.ApiParameterModels.ApiParameterModelBase
        {
            MemberInfo memberInfo = (keySelector.Body as MemberExpression).Member;

            return memberInfo.GetApiParameterName();
        }

        private static string GetApiParameterName(this MemberInfo memberInfo)
        {
            CustomAttributeData apiParameterAttribute = memberInfo.CustomAttributes.FirstOrDefault(attr => attr.AttributeType == typeof(ApiParameterNameAttribute));
            if (apiParameterAttribute == null)
            {
                Type[] interfaceTypes = memberInfo.ReflectedType.GetInterfaces();
                if (memberInfo.MemberType == MemberTypes.Field)
                {
                    apiParameterAttribute = interfaceTypes.FirstOrDefault(i => i.GetFields().Any(f => f.Name.Equals(memberInfo.Name)))
                        ?.GetField(memberInfo.Name).CustomAttributes.FirstOrDefault(attr => attr.AttributeType == typeof(ApiParameterNameAttribute));
                }
                else if (memberInfo.MemberType == MemberTypes.Property)
                {
                    apiParameterAttribute = interfaceTypes.FirstOrDefault(i => i.GetProperties().Any(p => p.Name.Equals(memberInfo.Name)))
                        ?.GetProperty(memberInfo.Name).CustomAttributes.FirstOrDefault(attr => attr.AttributeType == typeof(ApiParameterNameAttribute));
                }
                else if (memberInfo.MemberType == MemberTypes.Method)
                {
                    apiParameterAttribute = interfaceTypes.FirstOrDefault(i => i.GetMethods().Any(m => m.Name.Equals(memberInfo.Name)))
                        ?.GetMethod(memberInfo.Name).CustomAttributes.FirstOrDefault(attr => attr.AttributeType == typeof(ApiParameterNameAttribute));
                }
            }
            string targetApiParameterName = apiParameterAttribute?.ConstructorArguments.FirstOrDefault().Value?.ToString();
            if (string.IsNullOrWhiteSpace(targetApiParameterName))
            {
                targetApiParameterName = memberInfo.Name;
            }

            return targetApiParameterName;
        }

    }
}
