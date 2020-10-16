using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Enums;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Response.Tax
{
    /// <summary>
    /// 个税申报状态查询响应模型
    /// </summary>
    public class TaxDeclarationStatusResponseModel : IBusinessResponseModel
    {

        /// <summary>
        /// 申报任务受理ID
        /// <para>
        /// 和申报服务输出的一致，回调时客户系统通过该ID匹配
        /// </para>
        /// </summary>
        [ApiParameterName("accept_id")]
        public string AcceptId { get; set; }

        /// <summary>
        /// 综合所得预扣预缴申报表申报结果
        /// </summary>
        [ApiParameterName("ykyjsbjg")]
        public DeclarationResult YukouYujiaoShenbaoJieguo { get; set; }

        /// <summary>
        /// 一般分类所得申报表申报结果
        /// </summary>
        [ApiParameterName("flsdsbjg")]
        public DeclarationResult FenleiSuodeShenbaoJieguo { get; set; }

        /// <summary>
        /// 非居民所得申报表申报结果
        /// </summary>
        [ApiParameterName("fjmsbjg")]
        public DeclarationResult FeiJuminShenbaoJieguo { get; set; }
    }

    /// <summary>
    /// 申报表申报结果
    /// </summary>
    public class DeclarationResult 
    { 
        /// <summary>
        /// 总金额
        /// </summary>
        [ApiParameterName("zje")]
        public decimal ZongJinE { get; set; }

        /// <summary>
        /// 总人数
        /// </summary>
        [ApiParameterName("zrs")]
        public int ZongRenshu { get; set; }

        /// <summary>
        /// 应纳税额
        /// </summary>
        [ApiParameterName("ynse")]
        public decimal YingNashuie { get; set; }

        /// <summary>
        /// 申报标志
        /// </summary>
        [ApiParameterName("sbbz")]
        public DeclarationFlag ShenbaoBiaozhi { get; set; }

        /// <summary>
        /// 申报反馈标志
        /// </summary>
        [ApiParameterName("sbfkbz")]
        public FeedbackFlag ShenbaoFankuiBiaozhi { get; set; }

        /// <summary>
        /// 申报反馈信息
        /// </summary>
        [ApiParameterName("sbfkxx")]
        public string ShenbaoFankuiXinxi { get; set; }

        /// <summary>
        /// 扣款反馈标志
        /// </summary>
        [ApiParameterName("kkfkbz")]
        public DeductionFlag KoukuanFankuiBiaozhi { get; set; }

        /// <summary>
        /// 扣款反馈信息
        /// </summary>
        [ApiParameterName("kkfkxx")]
        public string KoukuanFankuiXinxi { get; set; }

        /// <summary>
        /// 申报表起劲信息
        /// </summary>
        [ApiParameterName("yjsbsed")]
        public string ErrorInfo { get; set; }
    }
}
