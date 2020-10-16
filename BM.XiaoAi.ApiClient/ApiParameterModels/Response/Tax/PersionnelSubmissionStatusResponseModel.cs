using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Converters;
using BM.XiaoAi.ApiClient.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Response.Tax
{
    /// <summary>
    /// 人员信息报送状态查询响应模型
    /// </summary>
    public class PersionnelSubmissionStatusResponseModel : IBusinessResponseModel
    {
        /// <summary>
        /// 人员报送处理过程的错误信息
        /// </summary>
        [ApiParameterName("errorinfo")]
        public string ErrorInfo { get; set; }

        /// <summary>
        /// *受理ID
        /// </summary>
        /// <remarks>
        /// 人员报送受理ID。和报送服务输出的一致，回调时客户系统通过该ID匹配
        /// </remarks>
        [ApiParameterName("accept_id")]
        public string AcceptId { get; set; }

        /// <summary>
        /// 行政区划代码 <para>企业所属地区行政区划代码</para>
        /// </summary>
        [ApiParameterName("areaid")]
        [JsonConverter(typeof(EnumValueStringConverter))]
        public Administrative? AreaId { get; set; }

        /// <summary>
        /// 报送结果 报送/反馈成功时包含此内容
        /// </summary>
        [ApiParameterName("bsjg")]
        public List<PersinnelSubmissionResult> PersinnelSubmissionResults { get; set; }
    }

    /// <summary>
    /// 人员报送结果
    /// </summary>
    public class PersinnelSubmissionResult
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [ApiParameterName("xm")]
        public string Xingming { get; set; }

        /// <summary>
        /// 证照类型
        /// </summary>
        [ApiParameterName("zzlx")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LicenseType ZhengzhaoLeixing { get; set; }

        /// <summary>
        /// 证照号码
        /// </summary>
        [ApiParameterName("zzhm")]
        public string ZhengzhaoHaoma { get; set; }

        /// <summary>
        /// 自然人登记序号
        /// </summary>
        [ApiParameterName("zrrdjxh")]
        public string ZiranrenDengjiXuhao { get; set; }

        /// <summary>
        /// 自然人档案号
        /// </summary>
        [ApiParameterName("zrrdah")]
        public string ZiranrenDangAnHao { get; set; }

        /// <summary>
        /// 自然人纳税人识别号
        /// </summary>
        [ApiParameterName("zrrnsrsbh")]
        public string ZiranrenNashuirenShibiehao { get; set; }

        /// <summary>
        /// 人员数据入库状态 <para>0-成功；-1-失败；1-有提示</para>
        /// </summary>
        [ApiParameterName("drzt")]
        public int RenyuanShujuRukuZhuangtai { get; set; }

        /// <summary>
        /// 人员报送状态
        /// </summary>
        [ApiParameterName("sbzt")]
        public PersonnelSubmissionStatus RenyuanBaosongZhuangtai { get; set; }

        /// <summary>
        /// 人员验证状态
        /// </summary>
        [ApiParameterName("rzzt")]
        public PersonnelVerificationStatus RenyuanYanzhengZhuangtai { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [ApiParameterName("sbyy")]
        public string ShibaiYuanyin { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [ApiParameterName("khyh")]
        public string KaihuYinhang { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        [ApiParameterName("yhzh")]
        public string YinhangZhanghao { get; set; }

        /// <summary>
        /// 开户银行省份
        /// </summary>
        [ApiParameterName("khyh_sheng")]
        public string KaihuYinhangSheng { get; set; }

        /// <summary>
        /// 银行账号验证状态
        /// </summary>
        [ApiParameterName("yhzhyzzt")]
        public BankAccountVerificationStatus? YinhangZhanghaoYanzhengZhuangtai { get; set; }

        /// <summary>
        /// 银行账号验证信息
        /// </summary>
        /// <remarks>
        /// 核验失败原因内容有：
        /// <list type="number">
        /// <item>输入的卡号无效</item>
        /// <item>卡状态不正确</item>
        /// <item>持卡人身份信息或手机号输入不正确</item>
        /// <item>银行卡暂不支持该业务</item>
        /// <item>银行卡未开通认证支付</item>
        /// </list>
        /// </remarks>
        [ApiParameterName("yhzhyzxx")]
        public string YinhangZhanghaoYanzhengXinxi { get; set; }
    }

    /// <summary>
    /// 企业税务信息
    /// </summary>
    public class EnterpriseTaxInfo 
    {
        /// <summary>
        /// *扣缴单位纳税人识别号
        /// </summary>
        [ApiParameterName("nsrsbh")]
        public string NashuirenShibiehao { get; set; }

        /// <summary>
        /// 纳税人登记序号
        /// </summary>
        [ApiParameterName("djxh")]
        public string DengjiXuhaoId { get; set; }

        /// <summary>
        /// 主管税务机关名称
        /// </summary>
        [ApiParameterName("zgswjmc")]
        public string ZhuguanShuiwuJiguanMingCheng { get; set; }

        /// <summary>
        /// 登记注册名称
        /// </summary>
        [ApiParameterName("djzcmc")]
        public string DengjiZhuceMingCheng { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [ApiParameterName("lxdh")]
        public string LianxiDianhua { get; set; }

        /// <summary>
        /// 联系地址
        /// </summary>
        [ApiParameterName("lxdz")]
        public string LianxiDizhi { get; set; }

        /// <summary>
        /// 登记日期
        /// </summary>
        [ApiParameterName("djrq")]
        public string DengjiRiqi { get; set; }
    }
}
