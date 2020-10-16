using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Income
{
    /// <summary>
    /// 个人偶然所得
    /// </summary>
    public class PersonalIncidentalIncomeInfo : PersonalIncomeInfoBase
    {

        /// <summary>
        /// 是否汇总申报 [是]/[否]。凡不为[是]均为[否]
        /// </summary>
        /// <remarks>
        /// 如[是]则代表这一条数据时汇总申报数据。汇总申报姓名、证照类型、证照号码均无须填写，减免税额不支持填写。<para/>
        /// 企业需在税局开通汇总申报才可录入汇总数据，否则该数据将返回错误：“如需汇总申报，请先前往办税服务厅进行开通”
        /// </remarks>
        [ApiParameterName("sfhzsb")]
        public bool? ShifouHuizongShenbao { get; set; }

        /// <summary>
        /// 所得项目代码
        /// </summary>
        /// <remarks>
        /// 1005-社会福利募捐奖金、体彩奖金
        /// <list type="table">非居民偶然所得
        /// <item>1001-省级、部级、军级奖金</item>
        /// <item>1002-外国组织和国际组织奖金</item>
        /// <item>1003-见义勇为奖金</item>
        /// <item>1004-举报、协查违法犯罪奖金</item>
        /// <item>1006-有奖发票奖金</item>
        /// <item>1007-随机赠送礼品</item>
        /// <item>1099-其他偶然所得</item>
        /// </list>
        /// </remarks>
        [ApiParameterName("sdxm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IncomeItem SuodeXiangmu { get; set; }

        /// <summary>
        /// 实际捐赠额
        /// </summary>
        [ApiParameterName("sjjze")]
        public decimal? ShijiJuanzengE { get; set; }

        /// <summary>
        /// 捐赠方式
        /// <para>[限额扣除]/[全额扣除]/ [混合]。默认[限额扣除]</para>
        /// </summary>
        [ApiParameterName("jzlx")]
        public string JuanzengLeixing { get; set; }

        /// <summary>
        /// 准予扣除捐赠额
        /// <para>【捐赠方式】填混合时，该字段可填写，否则填写无效</para>
        /// </summary>
        [ApiParameterName("zykcjze")]
        public decimal? ZhunyuKouchuJuanzengE { get; set; }

        /// <summary>
        /// 应纳税所得额
        /// </summary>
        [ApiParameterName("ynssde")]
        public new decimal? YingNashuiSuodeE { get; set; }

        /// <summary>
        /// 应纳税额
        /// </summary>
        [ApiParameterName("ynse")]
        public new decimal? YingNashuie { get; set; }

        /// <summary>
        /// 应扣缴税额
        /// </summary>
        [ApiParameterName("yingkjse")]
        public new decimal? YingKoujiaoShuie { get; set; }
    }
}
