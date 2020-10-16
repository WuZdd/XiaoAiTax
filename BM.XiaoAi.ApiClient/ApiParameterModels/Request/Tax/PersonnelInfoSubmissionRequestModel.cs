using BM.XiaoAi.ApiClient.Attributes;
using System.Collections.Generic;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Request.Tax
{
    /// <summary>
    /// 人员信息报送请求模型
    /// <para>
    /// 小爱约定请求都通过HttpPost的Body发送，采用utf-8编码的application/json请求 
    /// </para>
    /// </summary>
    public class PersonnelInfoSubmissionRequestModel : TaxRequestModel, IExtraTaxUriPathRequestModel
    {
        /// <summary>
        /// 总人数
        /// </summary>
        [ApiParameterName("zrs")]
        public int ZongRenshu { get; set; }

        /// <summary>
        /// 纳税人数据 外籍人员见 <see cref="AlienTaxpayerDetail"/>
        /// </summary>
        [ApiParameterName("nsrlb")]
        public List<TaxpayerDetail> Taxpayers { get; set; }
    }

    
}
