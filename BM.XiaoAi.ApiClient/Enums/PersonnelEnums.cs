using System;
using System.Runtime.Serialization;

namespace BM.XiaoAi.ApiClient.Enums
{
    /// <summary>
    /// 证照类型字典
    /// </summary>
    public enum LicenseType
    {
        居民身份证,

        中国护照,

        港澳居民来往内地通行证,

        港澳居民居住证,

        台湾居民来往大陆通行证,

        台湾居民居住证,

        外国护照,

        外国人永久居留身份证,

        /// <summary>
        /// 外国人工作许可证（A类）——注意这个括号是大写的
        /// </summary>
        [EnumMember(Value = "外国人工作许可证（A类）")]
        外国人工作许可证_A,

        /// <summary>
        /// 外国人工作许可证（B类）——注意这个括号是大写的
        /// </summary>
        [EnumMember(Value = "外国人工作许可证（B类）")]
        外国人工作许可证_B,

        /// <summary>
        /// 外国人工作许可证（C类）——注意这个括号是大写的
        /// </summary>
        [EnumMember(Value = "外国人工作许可证（C类）")]
        外国人工作许可证_C,
    }

    /// <summary>
    /// 学历字典
    /// </summary>
    public enum Education
    {
        大学本科以下,
        大学本科,
        研究生
    }

    /// <summary>
    /// 任职受雇从业类型
    /// </summary>
    public enum EmploymentType
    {
        雇员,
        保险营销员,
        证券经纪人,
        其他
    }

    [Flags]
    public enum TaxRelatedReasons
    {
        任职受雇 = 1,
        提供临时劳务 = 2,
        转让财产 = 4,
        从事投资和经营活动 = 8,
        其他 = 16
    }

}
