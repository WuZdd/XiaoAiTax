using BM.XiaoAi.ApiClient.ApiParameterModels.Generic;
using BM.XiaoAi.ApiClient.Attributes;
using BM.XiaoAi.ApiClient.Converters;
using BM.XiaoAi.ApiClient.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Request
{
    /// <summary>
    /// 纳税人详情
    /// </summary>
    public class TaxpayerDetail : PersonalBasicInfo
    {
        /// <summary>
        /// *国籍（地区）
        /// </summary>
        [ApiParameterName("gj")]
        public string Nationality { get; set; }

        /// <summary>
        /// *性别 [男]/[女]
        /// </summary>
        [ApiParameterName("xb")]
        public string Gender { get; set; }

        /// <summary>
        /// *出生日期
        /// <para>
        /// yyyy-mm-dd 不能大于等于当前系统时间
        /// </para>
        /// </summary>
        [ApiParameterName("csny")]
        public string BirthDate { get; set; }

        /// <summary>
        /// 纳税人状态 [正常]/[非正常]
        /// </summary>
        [ApiParameterName("nsrzt")]
        public string Status { get; set; }

        /// <summary>
        /// 是否扣除减除费用 [是]/[否]
        /// <para>
        /// 默认为是，如果填否，则在计算预扣预缴税款（正常工资薪金所得、保险营销员和证券经纪人的劳务报酬）时，减除费用默认为0，不可减除。
        /// </para>
        /// </summary>
        [ApiParameterName("sfkcjcfy")]
        [JsonConverter(typeof(BooleanChineseStringConverter))]
        public bool? IsDeductionExpenses { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        [ApiParameterName("xl")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Education? Education { get; set; }

        /// <summary>
        /// 是否残疾 [是]/[否]
        /// </summary>
        [ApiParameterName("sfcj")]
        [JsonConverter(typeof(BooleanChineseStringConverter))]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// 是否烈属 [是]/[否]
        /// </summary>
        [ApiParameterName("sfls")]
        [JsonConverter(typeof(BooleanChineseStringConverter))]
        public bool? IsMartyrsFamilies { get; set; }

        /// <summary>
        /// 是否孤老 [是]/[否]
        /// </summary>
        [ApiParameterName("sfgl")]
        [JsonConverter(typeof(BooleanChineseStringConverter))]
        public bool? IsOldAndLonely { get; set; }

        /// <summary>
        /// 残疾证号
        /// <para>
        /// 【是否残疾】填[是]时必填
        /// </para>
        /// </summary>
        [ApiParameterName("cjzh")]
        public string DisabilityCardNumber { get; set; }

        /// <summary>
        /// 烈属证号
        /// <para>
        /// 【是否烈属】填[是]时必填
        /// </para>
        /// </summary>
        [ApiParameterName("lszh")]
        public string MartyrsFamilyCardNumber { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [ApiParameterName("bz")]
        public string Remark { get; set; }

        /// <summary>
        /// 经常居住地_省
        /// </summary>
        [ApiParameterName("lxdz_sheng")]
        public string HabitualResidence_Province { get; set; }

        /// <summary>
        /// 经常居住地_市
        /// </summary>
        [ApiParameterName("lxdz_shi")]
        public string HabitualResidence_City { get; set; }

        /// <summary>
        /// 经常居住地_区县
        /// </summary>
        [ApiParameterName("lxdz_qx")]
        public string HabitualResidence_District { get; set; }

        /// <summary>
        /// 经常居住地_街道
        /// </summary>
        [ApiParameterName("lxdz_jd")]
        public string HabitualResidence_Street { get; set; }

        /// <summary>
        /// 经常居住地_详细
        /// <para>
        /// 除了街道不要求必填以外，其他四项全部填写或全部不填写。见《居住地字典》需要以汉字的形式填写
        /// </para>
        /// </summary>
        [ApiParameterName("lxdz")]
        public string HabitualResidence { get; set; }

        /// <summary>
        /// 户籍地址_省
        /// </summary>
        [ApiParameterName("hjszd_sheng")]
        public string PermanentAddress_Province { get; set; }

        /// <summary>
        /// 户籍地址_市
        /// </summary>
        [ApiParameterName("hjszd_shi")]
        public string PermanentAddress_City { get; set; }

        /// <summary>
        /// 户籍地址_区县
        /// </summary>
        [ApiParameterName("hjszd_qx")]
        public string PermanentAddress_District { get; set; }

        /// <summary>
        /// 户籍地址_街道
        /// </summary>
        [ApiParameterName("hjszd_jd")]
        public string PermanentAddress_Street { get; set; }

        /// <summary>
        /// 户籍地址_详细
        /// <para>
        /// 除了街道不要求必填以外，其他四项全部填写或全部不填写。见《居住地字典》需要以汉字的形式填写
        /// </para>
        /// </summary>
        [ApiParameterName("hjszd_xxdz")]
        public string PermanentAddress { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [ApiParameterName("lxdh")]
        public string Mobile { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        [ApiParameterName("dzyx")]
        public string Email { get; set; }

        /// <summary>
        /// 开户银行 见《银行字典》
        /// <para>
        /// 银行信息如填写其中一项则其他项必填
        /// </para>
        /// </summary>
        [ApiParameterName("khyh")]
        public string Bank { get; set; }

        /// <summary>
        /// 开户银行省份
        /// </summary>
        [ApiParameterName("khyh_sheng")]
        public string Bank_Province { get; set; }

        /// <summary>
        /// 银行账号
        /// <para>
        /// 境内、境外人员的“银行账户”输入时，只能录入8-30位的数字
        /// </para>
        /// </summary>
        [ApiParameterName("yhzh")]
        public string Bank_Account { get; set; }

        /// <summary>
        /// *任职受雇从业类型
        /// </summary>
        [ApiParameterName("sfgy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EmploymentType EmploymentType { get; set; }

        /// <summary>
        /// 任职受雇日期
        /// <para>
        /// yyyy-mm-dd。任职受雇从业类型为雇员、保险营销员、证券经纪人都必填。如需要申报工资薪金所得，则该字段必填。
        /// </para>
        /// </summary>
        [ApiParameterName("rzsgrq")]
        public string EmployementDate { get; set; }

        /// <summary>
        /// 离职日期
        /// <para>
        /// yyyy-mm-dd。雇员的【人员状态】填[非正常]时必填
        /// </para>
        /// </summary>
        [ApiParameterName("lzrq")]
        public string DepartureDate { get; set; }

        /// <summary>
        /// 是否并档 [是]/[否]
        /// <para>
        /// 默认为否，如果填是，则在人员报送完成后，系统会将所有标记为是的人员并且报送成功的，执行人员并档操作。
        /// </para>
        /// <para>
        /// 人员并档逐个人员进行，大批量的并档会导致接口长时间无法返回结果
        /// </para>
        /// </summary>
        [ApiParameterName("sfbd")]
        [JsonConverter(typeof(BooleanChineseStringConverter))]
        public bool? IsMergeFiles { get; set; }

        /// <summary>
        /// 个人投资总额
        /// <para>
        /// 当为股东投资者时必填
        /// </para>
        /// </summary>
        [ApiParameterName("grgbze")]
        public decimal? PersonalInvestmentTotal { get; set; }

        /// <summary>
        /// 职务
        /// </summary>
        [ApiParameterName("zw")]
        public string Post { get; set; }

        /// <summary>
        /// 个人投资比例
        /// <para>
        /// 没有则不填，范围为0~100，不包含0
        /// </para>
        /// </summary>
        [ApiParameterName("grtzbl")]
        public decimal? PersonalInvestmentProportion { get; set; }
    }

    /// <summary>
    /// 外籍纳税人信息
    /// </summary>
    public class AlienTaxpayerDetail : TaxpayerDetail
    {
        /// <summary>
        /// 中文名
        /// </summary>
        [ApiParameterName("xmzw")]
        public string ChineseName { get; set; }

        /// <summary>
        /// 其他证照类型
        /// <list type="number">
        /// <item>当“证照类型”选择为如下类型时：
        /// <para>外国人永久居留身份证 外国人工作许可证（A类）外国人工作许可证（B类）外国人工作许可证（C类）</para>
        /// 本项内容为必填项，且只能选择为“外国护照”</item>
        /// <item>当“证照类型”选择为“港澳居民居住证”时，本项内容为必填项，且只能选择为“港澳居民来往内地通行证”；</item>
        /// <item>当“证照类型”选择为“台湾居民居住证”时，本项内容为必填项，且只能选择为“台湾居民来往大陆通行证”。</item>
        /// </list>
        /// <para>
        /// 当证照类型选择“中国护照”、“港澳居民来往内地通行证”、“台湾居民来往大陆通行证”、“外国护照”时，其他证照类型可选项中增加对应的照证类型可选项，如“外国护照”，则“其他证照类型”下拉项中也有“外国护照”，同时对应的号码规则仍有校验。非必填（用于更换护照）
        /// </para>
        /// </summary>
        [ApiParameterName("qtzzlx")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LicenseType? OtherLicenseType { get; set; }

        /// <summary>
        /// 其他证件号码
        /// </summary>
        [ApiParameterName("qtzzhm")]
        public string OtherLicenseNumber { get; set; }

        /// <summary>
        /// *出生地 详见【国籍地区字典】
        /// </summary>
        [ApiParameterName("csd")]
        public string Birthplace { get; set; }

        /// <summary>
        /// 涉税事由
        /// <para>
        /// 格式为：任职受雇, 转让财产, 其他
        /// 每个部分的值必须严格按照字典项中的值填写，否则数据无法保存。分隔符严格保证英文半角逗号,
        /// 如果不按照格式填写该参数，纳税人验证时无法正确截取值，可能导致某个值无法保存（不影响人员入库和报送，但是信息缺失）或者全部无法保存（返回“人员[涉税事由] 不能为空。”的错误）
        /// </para>
        /// </summary>
        [ApiParameterName("sssy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TaxRelatedReasons TaxRelatedReasons { get; set; }

        /// <summary>
        /// 首次入境时间
        /// <para>
        /// 雇员时必填YYYY-MM-DD
        /// </para>
        /// </summary>
        [ApiParameterName("scrjsj")]
        public string FirstEntryDate { get; set; }

        /// <summary>
        /// 预计离境时间
        /// </summary>
        [ApiParameterName("yjljsj")]
        public string EstimatedDepartureDate { get; set; }

        /// <summary>
        /// 联系地址_省
        /// </summary>
        [ApiParameterName("wjrlxdz_sheng")]
        public string ContactAddress_Province { get; set; }

        /// <summary>
        /// 联系地址_市
        /// </summary>
        [ApiParameterName("wjrlxdz_shi")]
        public string ContactAddress_City { get; set; }

        /// <summary>
        /// 联系地址_区县
        /// </summary>
        [ApiParameterName("wjrlxdz_qx")]
        public string ContactAddress_District { get; set; }

        /// <summary>
        /// 联系地址_街道
        /// </summary>
        [ApiParameterName("wjrlxdz_jd")]
        public string ContactAddress_Street { get; set; }

        /// <summary>
        /// 联系地址_详细
        /// <para>
        /// 除了街道不要求必填以外，其他四项全部填写或全部不填写。见《居住地字典》需要以汉字的形式填写
        /// </para>
        /// </summary>
        [ApiParameterName("wjrlxdz_xxdz")]
        public string ContactAddress { get; set; }
    }
}
