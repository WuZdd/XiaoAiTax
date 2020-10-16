using BM.XiaoAi.ApiClient.ApiParameterModels.Generic;
using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Request.Tax
{
    /// <summary>
    /// 累计算税数据下载请求模型
    /// </summary>
    public class CumulativeTaxDataDownloadRequestModel : TaxRequestModel
    {
        /// <summary>
        /// 下载专项信息
        /// <para>
        /// 是/否。默认为“否”，即不主动下载专项，预填时只以现有专项为预填依据
        /// </para>
        /// </summary>
        [ApiParameterName("xzzxxx")]
        [JsonConverter(typeof(BooleanChineseStringConverter))]
        public bool? XiazaiZhuanxiangXinxi { get; set; }

        /// <summary>
        /// 下载累计数据
        /// <para>
        /// 是/否。默认为“是”，即需要下载累计数据再计算税款
        /// </para>
        /// </summary>
        [ApiParameterName("xzljsj")]
        [JsonConverter(typeof(BooleanChineseStringConverter))]
        public bool? XiazaiLeijiShuju { get; set; }

        /// <summary>
        /// data对象，用来定义需要返回累计数据的人员
        /// <para>实测不能为空</para>
        /// </summary>
        [ApiParameterName("data")]
        public CumulativeTaxDataDownloadPersonnelData Data { get; set; } = new CumulativeTaxDataDownloadPersonnelData();
    }

    /// <summary>
    /// 累计算税数据下载人员对象 用来定义需要返回累计数据的人员
    /// </summary>
    public class CumulativeTaxDataDownloadPersonnelData
    {
        /// <summary>
        /// 人员列表
        /// </summary>
        /// <remarks>
        /// 当数组为空时，将返回报送中所得月份，人员状态为正常的所有人员的累计收入和专项扣除数据，包含所有境内人员和境外人员。
        /// </remarks>
        [ApiParameterName("rylb")]
        public List<PersonalBasicInfo> PersonnelList { get; set; }
    }
}
