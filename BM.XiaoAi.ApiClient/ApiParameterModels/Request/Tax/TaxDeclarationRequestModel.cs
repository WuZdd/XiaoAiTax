using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Request.Tax
{
    /// <summary>
    /// 个税申报请求模型
    /// </summary>
    public class TaxDeclarationRequestModel : TaxRequestModel, IExtraTaxUriPathRequestModel
    {

        /// <summary>
        /// 本次要申报的申报表。必填，否则不做申报操作
        /// </summary>
        [ApiParameterName("data")]
        public DeclarationForm Data { get; set; }
    }

    /// <summary>
    /// 申报表
    /// </summary>
    public class DeclarationForm 
    {
        /// <summary>
        /// 预扣预缴申报表。非必填。若有该对象则会尝试申报预扣预缴申报表
        /// </summary>
        [ApiParameterName("ykyj")]
        public DeclarationFormDetail YukouYujiao { get; set; }

        /// <summary>
        /// 分类所得申报表。非必填。若有该对象则会尝试申报分类所得申报表
        /// </summary>
        [ApiParameterName("flsd")]
        public DeclarationFormDetail FenleiSuode { get; set; }

        /// <summary>
        /// 非居民所得申报表。非必填。若有该对象则会尝试申报非居民所得申报表
        /// </summary>
        [ApiParameterName("fjm")]
        public DeclarationFormDetail FeiJumin { get; set; }
    }

    /// <summary>
    /// 申报表明细
    /// </summary>
    /// <remarks>
    /// 如填写，将在申报前核对，如果申报端系统中的申报表的总金额、总人数、应补(退)税额与传入的值不符，<para/>
    /// 将中止申报【工资的总金额为当前所得月份待申报人员的累计收入额之和，其他的为当期收入之和、总人数去重、ynse为应补退税额即本月应缴的金额】
    /// </remarks>
    public class DeclarationFormDetail
    { 
        /// <summary>
        /// 总金额
        /// </summary>
        [ApiParameterName("zje")]
        public decimal? ZongJinE { get; set; }

        /// <summary>
        /// 总人数 有相关所得则必填
        /// </summary>
        [ApiParameterName("zrs")]
        public int? ZongRenshu { get; set; }

        /// <summary>
        /// 应补(退)税额
        /// </summary>
        [ApiParameterName("ynse")]
        public decimal? YingNashuie { get; set; }
    }
}
