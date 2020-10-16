using BM.XiaoAi.ApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Withholding
{
    /// <summary>
    /// 个人全年一次性奖金信息
    /// </summary>
    public class PersonalMoneyAwardInfo : PersonalIncomeInfoBase
    {

        /// <summary>
        /// 准予扣除捐赠额
        /// </summary>
        [ApiParameterName("zykcjze")]
        public decimal? ZhuiyuKouchuJuanzengE { get; set; }
    }
}
