using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Converters;
using Newtonsoft.Json;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Withholding
{
    /// <summary>
    /// 个人解除劳务合同所得信息
    /// </summary>
    public class PersonalTerminationLaborContractInfo : PersonalTaxResult
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
        /// 一次性补偿
        /// </summary>
        [ApiParameterName("ycxbc")]
        public decimal YicixingBuchang { get; set; }

        /// <summary>
        /// 免税收入
        /// <para>如填写该项数据，需要在减免附表中填写【减免方式】为[免税所得]的附表数据</para>
        /// </summary>
        [ApiParameterName("mssr")]
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
        /// 准予扣除捐赠额
        /// </summary>
        [ApiParameterName("zykcjze")]
        public decimal? ZhunyuKouchuJuanzengE { get; set; }

        /// <summary>
        /// 备注
        /// <para>其他有内容则必填 <see cref="Qita"/></para>
        /// </summary>
        [ApiParameterName("bz")]
        public string Beizhu { get; set; }
    }
}
