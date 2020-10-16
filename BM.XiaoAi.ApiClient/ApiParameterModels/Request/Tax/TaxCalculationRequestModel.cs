using BM.XiaoAi.ApiClient.ApiParameterModels.Generic;
using BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Income;
using BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Income.NonResident;
using BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Reduction;
using BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Withholding;
using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Request.Tax
{
    /// <summary>
    /// 税款计算请求模型
    /// </summary>
    public class TaxCalculationRequestModel : TaxRequestModel
    {
        /// <summary>
        /// 专项自动扣除
        /// <para>[是]/[否]。默认为否。是否自动扣除专项附加。</para>
        /// </summary>
        /// <remarks>
        /// 如是则在算税前根据已有的专项附加扣除信息进行扣除，并忽略正常工资薪金中填写的专项附加扣除数据。
        /// </remarks>
        [ApiParameterName("zxzdkc")]
        [JsonConverter(typeof(BooleanChineseStringConverter))]
        public bool? ZhuanxiangZidongKouchu { get; set; }

        /// <summary>
        /// 总人数
        /// </summary>
        [ApiParameterName("zrs")]
        public int? ZongRenshu { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [ApiParameterName("zje")]
        public decimal? ZongJinE { get; set; }

        /// <summary>
        /// 收入数据块
        /// </summary>
        [ApiParameterName("data")]
        public IncomeData Data { get; set; }
    }

    /// <summary>
    /// 收入数据
    /// </summary>
    public class IncomeData
    {
        /// <summary>
        /// 预扣预缴
        /// </summary>
        [ApiParameterName("ykyj")]
        public YukouYujiao YukouYujiao { get; set; }

        /// <summary>
        /// 分类所得
        /// </summary>
        [ApiParameterName("flsd")]
        public FenleiSuode FenleiSuode { get; set; }

        /// <summary>
        /// 非居民所得
        /// </summary>
        [ApiParameterName("fjmsd")]
        public FeijuminSuode FeijuminSuode { get; set; }
    }

    /// <summary>
    /// 预扣预缴
    /// </summary>
    public class YukouYujiao
    {
        /// <summary>
        /// 清空当月数据
        /// <para>
        /// 是或否，不填默认为否（清空当前所得月份预扣预缴的全量数据）
        /// </para>
        /// </summary>
        [ApiParameterName("qkdysj")]
        [JsonConverter(typeof(BooleanChineseStringConverter))]
        public bool? QingkongDangyueShuju { get; set; }

        /// <summary>
        /// 正常工资薪金列表
        /// </summary>
        [ApiParameterName("zcgzxjlb")]
        public List<PersonalNormalSalaryInfo> ZhengchangGongziXinjinLiebiao { get; set; }

        /// <summary>
        /// 劳务报酬列表
        /// </summary>
        [ApiParameterName("lwbclb")]
        public List<PersonalLaborIncomeInfo> LaowuBaochouLiebiao { get; set; }

        /// <summary>
        /// 稿酬所得列表
        /// </summary>
        [ApiParameterName("gcsdlb")]
        public List<PersonalRemunerationInfo> GaochouSuodeLiebiao { get; set; }

        /// <summary>
        /// 全年一次性奖金列表
        /// </summary>
        [ApiParameterName("qnycxjjlb")]
        public List<PersonalMoneyAwardInfo> QuannianYicixingJiangjinLiebiao { get; set; }

        /// <summary>
        /// 减免事项附表列表
        /// </summary>
        [ApiParameterName("jmsxfblb")]
        public List<ReductionItemSchedule> JianmianShixiangFubiaoLiebiao { get; set; }

        /// <summary>
        /// 商业健康保险附表列表
        /// </summary>
        [ApiParameterName("syjkbxlb")]
        public List<CommercialHealthInsuranceSchedule> ShangyeJiankangBaoxianLiebiao { get; set; }

        /// <summary>
        /// 税延养老保险附表列表
        /// </summary>
        [ApiParameterName("syylbxlb")]
        public List<TaxDeferredEndowmentInsuranceSchedule> ShuiyanYanglaoBaoxianLiebiao { get; set; }

        /// <summary>
        /// 解除劳动合同列表
        /// </summary>
        [ApiParameterName("jcldhtlb")]
        public List<PersonalTerminationLaborContractInfo> JiechuLaodongHetongLiebiao { get; set; }

        /// <summary>
        /// 个人股权激励列表
        /// </summary>
        [ApiParameterName("gqjlln")]
        public List<PersonalEquityIncentiveInfo> GuquanJiliLiebiao { get; set; }

        /// <summary>
        /// 保险营销员、证券经纪人劳务报酬列表
        /// </summary>
        [ApiParameterName("bxzqlwlb")]
        public List<PersonalInsuranceSecuritiesInfo> BaoxianZhengquanLaowuLiebiao { get; set; }

        /// <summary>
        /// 捐赠附表列表
        /// </summary>
        [ApiParameterName("jzfblb")]
        public List<DonationDeductionSchedule> JuanzengFubiaoLiebiao { get; set; }
    }

    /// <summary>
    /// 分类所得
    /// </summary>
    public class FenleiSuode
    {
        /// <summary>
        /// 偶然所得列表
        /// </summary>
        [ApiParameterName("orsdlb")]
        public List<PersonalIncidentalIncomeInfo> OuranSuodeLiebiao { get; set; }
    }

    /// <summary>
    /// 非居民所得
    /// </summary>
    public class FeijuminSuode 
    {
        /// <summary>
        /// 清空当月数据
        /// <para>
        /// 是或否，不填默认为否（清空当前所得月份非居民所得的全量数据）
        /// </para>
        /// </summary>
        [ApiParameterName("qkdysj")]
        [JsonConverter(typeof(BooleanChineseStringConverter))]
        public bool? QingkongDangyueShuju { get; set; }

        /// <summary>
        /// 正常工资薪金（外籍人工资薪金）列表
        /// </summary>
        [ApiParameterName("wjgzxjlb")]
        public List<NonResidentNormalSalaryInfo> WaijiGongziXinjinLiebiao { get; set; }

        /// <summary>
        /// 外籍人数月奖金列表
        /// </summary>
        [ApiParameterName("wjsyjjlb")]
        public List<NonResidentMoneyAwardInfo> WaijiShuyueJiangjinLiebiao { get; set; }

        /// <summary>
        /// 解除劳动合同列表
        /// </summary>
        [ApiParameterName("jcldhtlb")]
        public List<NonResidentTerminationLaborContractInfo> JiechuLaodongHetongLiebiao { get; set; }

        /// <summary>
        /// 劳务报酬列表
        /// </summary>
        [ApiParameterName("lwbclb")]
        public List<NonResidentLaborIncomeInfo> LaowuBaochouLiebiao { get; set; }

        /// <summary>
        /// 减免事项附表列表
        /// </summary>
        [ApiParameterName("jmsxfblb")]
        public List<ReductionItemSchedule> JianmianShixiangFubiaoLiebiao { get; set; }

        /// <summary>
        /// 股权激励列表
        /// </summary>
        [ApiParameterName("gqjllb")]
        public List<NonResidentEquityIncentiveInfo> GuquanJiliLiebiao { get; set; }

        /// <summary>
        /// 捐赠附表列表
        /// </summary>
        [ApiParameterName("jzfblb")]
        public List<DonationDeductionSchedule> JuanzengFubiaoLiebiao { get; set; }

        /// <summary>
        /// 偶然所得列表
        /// </summary>
        [ApiParameterName("orsdlb")]
        public List<PersonalIncidentalIncomeInfo> OuranSuodeLiebiao { get; set; }
    }
}
