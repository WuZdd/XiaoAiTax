using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Enums;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Response.Tax
{
    /// <summary>
    /// 个税申报作废状态查询响应模型
    /// </summary>
    public class TaxDeclarationCancelStatusResponseModel : IBusinessResponseModel
    {
        /// <summary>
        /// 作废任务受理ID
        /// <para>
        /// 和申报作废服务输出的一致，回调时客户系统通过该ID匹配
        /// </para>
        /// </summary>
        [ApiParameterName("accept_id")]
        public string AcceptId { get; set; }

        /// <summary>
        /// 综合所得预扣预缴申报表申报结果
        /// </summary>
        [ApiParameterName("ykyjsbjg")]
        public DeclarationCancelResult YukouYujiaoShenbaoJieguo { get; set; }

        /// <summary>
        /// 一般分类所得申报表申报结果，json对象
        /// </summary>
        [ApiParameterName("flsdsbjg")]
        public DeclarationCancelResult FenleiSuodeShenbaoJieguo { get; set; }

        /// <summary>
        /// 非居民所得申报表申报结果
        /// </summary>
        [ApiParameterName("fjmsbjg")]
        public DeclarationCancelResult FeiJuminShenbaoJieguo { get; set; }
    }

    /// <summary>
    /// 申报作废结果
    /// </summary>
    public class DeclarationCancelResult 
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
        /// 作废标志
        /// </summary>
        [ApiParameterName("zfbz")]
        public CancellationFlag ZuofeiBiaozhi { get; set; }

        /// <summary>
        /// 作废批次号
        /// </summary>
        [ApiParameterName("zfpch")]
        public string ZuofeiPicihao { get; set; }

        /// <summary>
        /// 申报表信息
        /// </summary>
        [ApiParameterName("errorinfo")]
        public string ErrorInfo { get; set; }
    }
}
