using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Reduction
{
    /// <summary>
    /// 捐赠扣除附表
    /// </summary>
    public class DonationDeductionSchedule : PersonalBasicInfo
    {

        /// <summary>
        /// *所得项目代码
        /// </summary>
        [ApiParameterName("sdxm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IncomeItem SuodeXiangmu { get; set; }

        /// <summary>
        /// 捐赠明细列表
        /// </summary>
        /// <remarks>
        /// 每个捐赠附表主体都应包含至少1个捐赠明细，数组内为json对象
        /// </remarks>
        [ApiParameterName("jzmxlb")]
        public List<DonationDeductionDetail> JuanzengMingxiLiebiao { get; set; }

        /// <summary>
        /// 处理状态
        /// </summary>
        /// <remarks>
        /// 输出字段。-1：没有对应的捐赠扣除主体；1：未填写明细；2：已填写明细；3：明细待完善；4：无须填写明细。
        /// </remarks>
        [ApiParameterName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        /// <remarks>
        /// 输出字段。当处理有错误时通过该字段返回错误信息。该错误信息不包含扣除明细中的错误。
        /// </remarks>
        [ApiParameterName("errorinfo")]
        public string ErrorInfo { get; set; }
    }

    /// <summary>
    /// 捐赠扣除明细
    /// </summary>
    public class DonationDeductionDetail
    {
        /// <summary>
        /// *受赠单位名称
        /// </summary>
        [ApiParameterName("szdwmc")]
        public string ShouzengDanweiMingcheng { get; set; }

        /// <summary>
        /// 受赠单位纳税人识别号
        /// </summary>
        [ApiParameterName("szdwnsrsbh")]
        public string ShouzengDanweiNashuirenShibiehao { get; set; }

        /// <summary>
        /// 捐赠凭证号
        /// </summary>
        [ApiParameterName("jzpzh")]
        public string JuanzengPingzhenghao { get; set; }

        /// <summary>
        /// *捐赠日期 日期格式：YYYY-MM-DD。不可为空
        /// </summary>
        [ApiParameterName("jzrq")]
        public string JuanzengRiqi { get; set; }

        /// <summary>
        /// *捐赠金额
        /// </summary>
        [ApiParameterName("jzje")]
        public decimal JuanzengJinE { get; set; }

        /// <summary>
        /// 扣除比例
        /// <para>取值：【30%、100%】。不填、填写非取值范围，均默认30%</para>
        /// </summary>
        [ApiParameterName("kcbl")]
        public string KouchuBili { get; set; }

        /// <summary>
        /// 实际捐赠额
        /// </summary>
        /// <remarks>
        /// 目前在系统层面实际捐赠额和捐赠金额、扣除比例无关联关系。但是在业务层面存在关联关系
        /// </remarks>
        [ApiParameterName("sjjze")]
        public decimal ShijiJuanzenge { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [ApiParameterName("bz")]
        public string Beizhu { get; set; }

        /// <summary>
        /// 处理状态
        /// </summary>
        /// <remarks>
        /// 输出字段。-1：失败；0：成功；1：提示
        /// </remarks>
        [ApiParameterName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        /// <remarks>
        /// 输出字段。当处理有错误时通过该字段返回错误信息
        /// </remarks>
        [ApiParameterName("errorinfo")]
        public string ErrorInfo { get; set; }
    }
}
