using System.Runtime.Serialization;

namespace BM.XiaoAi.ApiClient.Enums
{
    /// <summary>
    /// 人员报送状态
    /// </summary>
    public enum PersonnelSubmissionStatus
    {
        未报送 = 0,
        待反馈 = 1,
        报送成功 = 2,
        报送失败 = 3
    }

    /// <summary>
    /// 人员验证状态
    /// </summary>
    public enum PersonnelVerificationStatus
    {
        待验证 = 0,
        验证中 = 1,
        验证通过 = 2,
        验证不通过 = 3,
        暂不验证 = 4
    }

    /// <summary>
    /// 银行账号验证状态
    /// </summary>
    public enum BankAccountVerificationStatus 
    {
        /// <summary>
        /// -1代表人员报送过程存在问题，没有进行到验证银行状态这一步骤
        /// </summary>
        未验证 = -1,
        待验证 = 0,
        验证中 = 1,
        验证通过 = 2,
        验证不通过 = 3,
        暂不验证 = 4
    }

    /// <summary>
    /// 所得项目代码
    /// </summary>
    public enum IncomeItem 
    { 
        [EnumMember(Value = "0101")]
        正常工资薪金,

        [EnumMember(Value = "0103")]
        全年一次性奖金,

        [EnumMember(Value = "0108")]
        解除劳务合同,

        [EnumMember(Value = "0109")]
        个人股权激励收入,

        [EnumMember(Value = "0401")]
        一般劳务报酬所得,

        [EnumMember(Value = "0402")]
        保险营销员劳务报酬所得,

        [EnumMember(Value = "0403")]
        证券经纪人劳务报酬所得,

        [EnumMember(Value = "0499")]
        其他劳务报酬所得,

        [EnumMember(Value = "0500")]
        稿酬所得,

        [EnumMember(Value = "1005")]
        社会福利募捐奖金_体彩奖金,


        [EnumMember(Value = "0102")]
        非居民_工资薪金,

        [EnumMember(Value = "0104")]
        非居民_数月奖金,

        [EnumMember(Value = "1001")]
        非居民_省级_部级_军级奖金,

        [EnumMember(Value = "1002")]
        非居民_外国组织和国际组织奖金,

        [EnumMember(Value = "1003")]
        非居民_见义勇为奖金,

        [EnumMember(Value = "1004")]
        非居民_举报_协查违法犯罪奖金,

        [EnumMember(Value = "1006")]
        非居民_有奖发票奖金,

        [EnumMember(Value = "1007")]
        非居民_随机赠送礼品,

        [EnumMember(Value = "1099")]
        非居民_其他偶然所得
    }
}
