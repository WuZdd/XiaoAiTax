using BM.XiaoAi.ApiClient.ApiParameterModels.Request.Tax;
using BM.XiaoAi.ApiClient.ApiParameterModels.Response;
using BM.XiaoAi.ApiClient.ApiParameterModels.Response.Tax;
using BM.XiaoAi.ApiClient.Filters;
using System;
using System.Threading;
using WebApiClient;
using WebApiClient.Attributes;

namespace BM.XiaoAi.ApiClient.ApiContract
{
    /// <summary>
    /// 个税相关接口
    /// </summary>
    public interface ITaxContract : IHttpApi
    {
        /// <summary>
        /// 人员报送
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="requestModel"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Timeout(5 * 1000)]
        [HttpPost("taxbot/v1/ryxxbs")]
        [JsonReturn]
        [ExtraRequestUriPathFilter(OrderIndex = 9)]
        ITask<Response<BusinessAcceptedModel>> PersonnelSubmission(
            [Header(HttpRequestHeader.Authorization)] string bearerToken, [JsonContent] PersonnelInfoSubmissionRequestModel requestModel, 
            [Timeout] TimeSpan? timeout = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// 人员报送状态查询
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="acceptId"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Timeout(5 * 1000)]
        [HttpGet("taxbot/v1/ryxxbsztcx/{acceptId}")]
        [JsonReturn]
        ITask<Response<PersionnelSubmissionStatusResponseModel>> GetPersonnelSubmissionResults(
            [Header(HttpRequestHeader.Authorization)] string bearerToken, [PathQuery] string acceptId,
            [Timeout] TimeSpan? timeout = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// 税款计算服务
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="requestModel"></param>
        /// <param name="sdyf"></param>
        /// <param name="acceptId"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Timeout(5 * 1000)]
        [HttpPost("taxbot/v1/skjs/{sdyf}/{acceptId}")]
        [JsonReturn]
        ITask<Response<BusinessAcceptedModel>> TaxCalculation(
            [Header(HttpRequestHeader.Authorization)] string bearerToken, [PathQuery] string sdyf, [PathQuery] string acceptId,
            [JsonContent] TaxCalculationRequestModel requestModel, 
            [Timeout] TimeSpan? timeout = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// 税款计算查询服务
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="skjsAcceptId">算税任务受理ID</param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Timeout(5 * 1000)]
        [HttpGet("taxbot/v1/skjscx/{skjsAcceptId}")]
        [JsonReturn]
        ITask<Response<TaxCalculationResponseModel>> GetTaxCalculationResults(
            [Header(HttpRequestHeader.Authorization)] string bearerToken, [PathQuery] string skjsAcceptId,
            [Timeout] TimeSpan? timeout = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// 累计算税数据下载
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="sdyf">所得月份</param>
        /// <param name="acceptId">人员报送反馈受理ID</param>
        /// <param name="requestModel"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Timeout(5 * 1000)]
        [HttpPost("taxbot/v1/ljsssjxz/{sdyf}/{acceptId}")]
        [JsonReturn]
        ITask<Response<BusinessAcceptedModel>> CumulativeTaxDataDownload(
            [Header(HttpRequestHeader.Authorization)] string bearerToken, [PathQuery] string sdyf, [PathQuery] string acceptId,
            [JsonContent] CumulativeTaxDataDownloadRequestModel requestModel,
            [Timeout] TimeSpan? timeout = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// 累计算税数据下载查询
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="ljssAcceptId">累计算税数据下载任务受理ID</param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Timeout(5 * 1000)]
        [HttpGet("taxbot/v1/ljsssjxzcx/{ljssAcceptId}")]
        [JsonReturn]
        ITask<Response<CumulativeTaxDataResponseModel>> GetCumulativeTaxData(
            [Header(HttpRequestHeader.Authorization)] string bearerToken, [PathQuery] string ljssAcceptId,
            [Timeout] TimeSpan? timeout = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// 个税申报服务
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="requestModel"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Timeout(5 * 1000)]
        [HttpPost("taxbot/v1/gssb")]
        [JsonReturn]
        [ExtraRequestUriPathFilter(OrderIndex = 9)]
        ITask<Response<BusinessAcceptedModel>> TaxDeclaration(
            [Header(HttpRequestHeader.Authorization)] string bearerToken, [JsonContent] TaxDeclarationRequestModel requestModel,
            [Timeout] TimeSpan? timeout = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// 个税申报状态查询服务
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="sbrwAcceptId">申报任务受理ID</param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Timeout(5 * 1000)]
        [HttpGet("taxbot/v1/gssbztcx/{sbrwAcceptId}")]
        [JsonReturn]
        ITask<Response<TaxDeclarationStatusResponseModel>> GetTaxDeclarationResults(
            [Header(HttpRequestHeader.Authorization)] string bearerToken, [PathQuery] string sbrwAcceptId,
            [Timeout] TimeSpan? timeout = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// 个税申报反馈服务
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="sbrwAcceptId">申报任务受理ID</param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Timeout(5 * 1000)]
        [HttpGet("taxbot/v1/gssbfk/{sbrwAcceptId}")]
        [JsonReturn]
        ITask<Response<BusinessAcceptedModel>> TaxDeclarationFeedback(
            [Header(HttpRequestHeader.Authorization)] string bearerToken, [PathQuery] string sbrwAcceptId,
            [Timeout] TimeSpan? timeout = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// 个税申报反馈状态查询服务
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="sbfkrwAcceptId">申报反馈任务受理ID</param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Timeout(5 * 1000)]
        [HttpGet("taxbot/v1/gssbfkztcx/{sbfkrwAcceptId}")]
        [JsonReturn]
        ITask<Response<TaxDeclarationStatusResponseModel>> GetTaxDeclarationFeedbackResults(
            [Header(HttpRequestHeader.Authorization)] string bearerToken, [PathQuery] string sbfkrwAcceptId,
            [Timeout] TimeSpan? timeout = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// 个税申报作废服务
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="requestModel"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Timeout(5 * 1000)]
        [HttpPost("taxbot/v1/gszf")]
        [JsonReturn]
        [ExtraRequestUriPathFilter(OrderIndex = 9)]
        ITask<Response<BusinessAcceptedModel>> TaxDeclarationCancel(
            [Header(HttpRequestHeader.Authorization)] string bearerToken, [JsonContent] TaxDeclarationCancelRequestModel requestModel,
            [Timeout] TimeSpan? timeout = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// 个数申报作废状态查询服务
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="zfrwAcceptId">作废任务受理ID</param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Timeout(5 * 1000)]
        [HttpGet("taxbot/v1/gszfztcx/{zfrwAcceptId}")]
        [JsonReturn]
        ITask<Response<TaxDeclarationCancelStatusResponseModel>> GetTaxDeclarationCancelResults(
            [Header(HttpRequestHeader.Authorization)] string bearerToken, [PathQuery] string zfrwAcceptId,
            [Timeout] TimeSpan? timeout = null, CancellationToken cancellationToken = default);
    }
}
