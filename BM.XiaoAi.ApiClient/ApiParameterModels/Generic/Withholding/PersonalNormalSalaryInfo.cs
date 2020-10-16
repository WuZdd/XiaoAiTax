using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic
{
    /// <summary>
    /// 人员正常工资薪金信息
    /// </summary>
    public class PersonalNormalSalaryInfo : PersonalTaxResult
    {
        /// <summary>
        /// 是否删除
        /// <para>
        /// 是/否，默认为否。[是]代表删除该人员在该所得项目中的历史数据
        /// </para>
        /// </summary>
        [ApiParameterName("sfsc")]
        public string ShifouShanchu { get; set; }

        /// <summary>
        /// 当期收入额
        /// </summary>
        /// <remarks>
        /// 当选择了适用公式1到公式4，则收入额会根据公式通过计算获得，不取通过服务传的 sre。 
        /// 若选择公式5，则收入额取通过服务传的sre
        /// </remarks>
        [ApiParameterName("sre")]
        public decimal? Shourue { get; set; }

        /// <summary>
        /// 适用公式 <para>证照类型为居民身份证不能填写，非居民不适用公式</para>
        /// </summary>
        /// <remarks>
        /// 当填写了适用公式，且不是公式5，则可以填写以下四项 
        /// <see cref="JingneiTianshu"/> <see cref="JingwaiTianshu"/> <see cref="JingneiZhifu"/> <see cref="JingwaiZhifu"/>，<para/>
        /// 一般情况下，境内工作天数+境外工作天数=当前所得月份总天数
        /// <list type="table">
        /// <item>[公式1]：=境内支付*境内工作天数/公历天数</item>
        /// <item>[公式2]：=收入总额*境内工作天数/公历天数</item>
        /// <item>[公式3]：=收入总额*[1-（境内支付/收入总额）*（境外工作天数/公历天数）]</item>
        /// <item>[公式4]：=境内支付</item>
        /// <item>[公式5]：=收入额</item>
        /// </list>
        /// </remarks>
        [ApiParameterName("sygs")]
        public string ShiyongGongshi { get; set; }

        /// <summary>
        /// 境内工作天数
        /// </summary>
        [ApiParameterName("jnts")]
        public decimal? JingneiTianshu { get; set; }

        /// <summary>
        /// 境外工作天数
        /// </summary>
        [ApiParameterName("jwts")]
        public decimal? JingwaiTianshu { get; set; }

        /// <summary>
        /// 境内支付金额
        /// </summary>
        [ApiParameterName("jnzf")]
        public decimal? JingneiZhifu { get; set; }

        /// <summary>
        /// 境外支付金额
        /// </summary>
        [ApiParameterName("jwzf")]
        public decimal? JingwaiZhifu { get; set; }

        /// <summary>
        /// 当期免税收入
        /// <para>如填写该项数据，需要在减免附表中填写【减免方式】为[免税所得]的附表数据</para>
        /// </summary>
        /// <remarks>
        /// *注：预扣预缴中“免税收入”和“免税所得”是同一概念，几处接口中有不同的表述和名称，实际是一样的。
        /// 此处统一用“免税所得”表述
        /// </remarks>
        [ApiParameterName("mssd")]
        public decimal? MianshuiSuode { get; set; }

        /// <summary>
        /// 准予扣除捐赠额
        /// </summary>
        [ApiParameterName("zykcjze")]
        public decimal? ZhunyuKouchuJuanzeng { get; set; }

        /// <summary>
        /// 基本养老保险
        /// </summary>
        [ApiParameterName("jbylaobxf")]
        public decimal? JibenYanglaoBaoxian { get; set; }

        /// <summary>
        /// 基本医疗保险
        /// </summary>
        [ApiParameterName("jbylbxf")]
        public decimal? JibenYiliaoBaoxian { get; set; }

        /// <summary>
        /// 失业保险
        /// </summary>
        [ApiParameterName("sybxf")]
        public decimal? ShiyeBaoxian { get; set; }

        /// <summary>
        /// 住房公积金
        /// </summary>
        [ApiParameterName("zfgjj")]
        public decimal? ZhufangGongjijin { get; set; }

        /// <summary>
        /// 子女教育支出
        /// </summary>
        [ApiParameterName("znjyzc")]
        public decimal? ZinvJiaoyuZhichu { get; set; }

        /// <summary>
        /// 赡养老人支出
        /// </summary>
        [ApiParameterName("sylrzc")]
        public decimal? ShanyangLaorenZhichu { get; set; }

        /// <summary>
        /// 住房贷款利息支出
        /// </summary>
        [ApiParameterName("zfdklxzc")]
        public decimal? ZhufangDaikuanLixiZhichu { get; set; }

        /// <summary>
        /// 住房租金支出
        /// </summary>
        [ApiParameterName("zfzjzc")]
        public decimal? ZhufangZujinZhichu { get; set; }

        /// <summary>
        /// 大病医疗支出
        /// </summary>
        [ApiParameterName("dbylzc")]
        public decimal? DabingYiliaoZhichu { get; set; }

        /// <summary>
        /// 继续教育支出
        /// </summary>
        [ApiParameterName("jxjyzc")]
        public decimal? JixuJiaoyuZhichu { get; set; }

        /// <summary>
        /// 年金
        /// </summary>
        [ApiParameterName("nj")]
        public decimal? Nianjin { get; set; }

        /// <summary>
        /// 商业健康保险
        /// <para>如填写该项数据，需要在减免附表中填写商业健康保险附表</para>
        /// </summary>
        [ApiParameterName("syjkbx")]
        public decimal? ShangyeJiankangBaoxian { get; set; }

        /// <summary>
        /// 税延养老保险
        /// <para>如填写该项数据，需要在减免附表中填写税延养老保险附表</para>
        /// </summary>
        [ApiParameterName("syylbx")]
        public decimal? ShuiyanYanglaoBaoxian { get; set; }

        /// <summary>
        /// 其他 按法律规定可以在税前扣除的项目
        /// </summary>
        [ApiParameterName("qt")]
        public decimal? Qita { get; set; }

        /// <summary>
        /// 减免税额
        /// <para>如填写该项数据，需要在减免附表中填写【减免方式】为[减免税额]的附表数据</para>
        /// </summary>
        [ApiParameterName("jmse")]
        public decimal? JianmianShuie { get; set; }

        /// <summary>
        /// 备注
        /// <para>其他有内容则必填 <see cref="Qita"/></para>
        /// </summary>
        [ApiParameterName("bz")]
        public string Beizhu { get; set; }

        /// <summary>
        /// 上期累计收入
        /// </summary>
        [ApiParameterName("ljsre")]
        public decimal? LeijiShouru { get; set; }

        /// <summary>
        /// 上期累计免税收入
        /// </summary>
        [ApiParameterName("ljmssr")]
        public decimal? LeijiMianshuiShouru { get; set; }

        /// <summary>
        /// 累计减除费用
        /// </summary>
        [ApiParameterName("jcfy")]
        public decimal? LeijiJianchuFeiyong { get; set; }

        /// <summary>
        /// 累计专项扣除合计
        /// </summary>
        [ApiParameterName("zxkchj")]
        public decimal? LeijiZhuanxiangKouchuHeji { get; set; }

        /// <summary>
        /// 累计其他扣除合计
        /// </summary>
        [ApiParameterName("qtckhj")]
        public decimal? LeijiQitaKouchuHeji { get; set; }

        /// <summary>
        /// 累计准予扣除的捐赠额
        /// </summary>
        [ApiParameterName("ljzykcdjze")]
        public decimal? LeijiZhunyuKouchuJuanzeng { get; set; }

        /// <summary>
        /// 累计专项附加扣除合计
        /// </summary>
        [ApiParameterName("zxfjkchj")]
        public decimal? LeijiZhuanxiangFujiaKouchuHeji { get; set; }
    }
}
