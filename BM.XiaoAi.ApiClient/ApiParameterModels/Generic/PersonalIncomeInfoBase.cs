using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Converters;
using Newtonsoft.Json;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic
{
    /// <summary>
    /// 个人所得信息基类
    /// </summary>
    public abstract class PersonalIncomeInfoBase : PersonalTaxResult
    {
        /// <summary>
        /// 是否删除
        /// <para>
        /// 是/否，默认为否。[是]代表删除该人员在该所得项目中的历史数据
        /// </para>
        /// </summary>
        [ApiParameterName("sfsc")]
        [JsonConverter(typeof(BooleanChineseStringConverter))]
        public bool? ShifouShanchu { get; set; }

        /// <summary>
        /// 当期收入额
        /// </summary>
        [ApiParameterName("sre")]
        public decimal Shourue { get; set; }

        /// <summary>
        /// 当期免税所得
        /// <para>如填写该项数据，需要在减免附表中填写【减免方式】为[免税所得]的附表数据</para>
        /// </summary>
        /// <remarks>
        /// *注：预扣预缴中“免税收入”和“免税所得”是同一概念，几处接口中有不同的表述和名称，实际是一样的。
        /// 此处统一用“免税所得”表述
        /// </remarks>
        [ApiParameterName("mssd")]
        public decimal? MianshuiSuode { get; set; }

        /// <summary>
        /// 其他 按法律规定可以在税前扣除的项目
        /// </summary>
        [ApiParameterName("qt")]
        public decimal? Qita { get; set; }

        /// <summary>
        /// 减免税额
        /// <para>如填写该项数据，需要在减免附表中填写【减免方式】为[减免税额]的附表数据</para>
        /// </summary>
        [ApiParameterName("jmse")]
        public decimal? JianmianShuie { get; set; }

        /// <summary>
        /// 备注
        /// <para>其他有内容则必填 <see cref="Qita"/></para>
        /// </summary>
        [ApiParameterName("bz")]
        public string Beizhu { get; set; }
    }
}
