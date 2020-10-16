namespace BM.XiaoAi.ApiClient.Enums
{
    /// <summary>
    /// 申报标志
    /// </summary>
    public enum DeclarationFlag
    {
        未申报 = 0,
        待申报 = 1,
        已申报 = 2,
        已作废 = 3
    }

    /// <summary>
    /// 反馈标志
    /// </summary>
    public enum FeedbackFlag 
    { 
        未反馈 = 0,
        接收成功 = 1,
        接收失败 = 2,
        申报成功 = 3,
        申报失败 = 4,
        局端处理中 = 5,
        申报作废 = 6,
        申报成功未接受处罚 = 7
    }

    /// <summary>
    /// 扣款标志
    /// </summary>
    public enum DeductionFlag 
    { 
        未扣款 = 0,
        扣款成功 = 1,
        反馈失败 = 2,
        无需扣款 = 3,
        扣款已冻结 = 4,
        已扣款未反馈 = 5,
        扣款状态不明 = 6
    }

    /// <summary>
    /// 作废标志
    /// </summary>
    public enum CancellationFlag
    {
        作废失败 = 0,
        作废成功 = 1,
        处理中 = 2,
        作废成功_申报状态变为未申报 = 3
    }
}
