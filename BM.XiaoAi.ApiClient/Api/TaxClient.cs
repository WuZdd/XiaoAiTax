using BM.XiaoAi.ApiClient.ApiContract;
using BM.XiaoAi.ApiClient.ApiParameterModels.Request.Tax;
using BM.XiaoAi.ApiClient.ApiParameterModels.Response;
using BM.XiaoAi.ApiClient.ApiParameterModels.Response.Tax;
using System;
using System.Threading;
using WebApiClient;

namespace BM.XiaoAi.ApiClient.Api
{
    /// <summary>
    /// 个税相关请求
    /// </summary>
    public class TaxClient
    {
        public ITaxContract TaxContract { get; }

        /// <summary>
        /// 个税Client
        /// </summary>
        /// <param name="taxContract"></param>
        public TaxClient(ITaxContract taxContract)
        {
            TaxContract = taxContract ?? HttpApi.Resolve<ITaxContract>();
        }

        /// <summary>
        /// 人员报送服务 <see cref="ITaxContract.PersonnelSubmission"/>
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="requestModel"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public ITask<Response<BusinessAcceptedModel>> PersonnelSubmission(
            string bearerToken, PersonnelInfoSubmissionRequestModel requestModel,
            TimeSpan? timeout = null, CancellationToken cancellationToken = default)
        {
            return TaxContract.PersonnelSubmission(bearerToken, requestModel, timeout, cancellationToken);
        }

        /// <summary>
        /// 人员报送状态查询 <see cref="ITaxContract.GetPersonnelSubmissionResults"/>
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="acceptId"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public ITask<Response<PersionnelSubmissionStatusResponseModel>> GetPersonnelSubmissionResults(
            string bearerToken, string acceptId, TimeSpan? timeout = null, CancellationToken cancellationToken = default)
        {
            return TaxContract.GetPersonnelSubmissionResults(bearerToken, acceptId, timeout, cancellationToken);
        }

        /// <summary>
        /// 税款计算服务 <see cref="ITaxContract.TaxCalculation"/>
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="requestModel"></param>
        /// <param name="acceptId"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public ITask<Response<BusinessAcceptedModel>> TaxCalculation(
            string bearerToken, TaxCalculationRequestModel requestModel, string acceptId,
            TimeSpan? timeout = null, CancellationToken cancellationToken = default)
        {
            return TaxContract.TaxCalculation(bearerToken, requestModel.SuodeYuefen, acceptId, requestModel, timeout, cancellationToken);
        }

        /// <summary>
        /// 税款计算查询服务 <see cref="ITaxContract.GetTaxCalculationResults"/>
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="skjsAcceptId">算税任务受理ID</param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public ITask<Response<TaxCalculationResponseModel>> GetTaxCalculationResults(
            string bearerToken, string skjsAcceptId, TimeSpan? timeout = null, CancellationToken cancellationToken = default)
        {
            return TaxContract.GetTaxCalculationResults(bearerToken, skjsAcceptId, timeout, cancellationToken);
        }

        /// <summary>
        /// 累计算税数据下载 <see cref="ITaxContract.CumulativeTaxDataDownload"/>
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="acceptId">人员报送反馈受理ID</param>
        /// <param name="requestModel"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public ITask<Response<BusinessAcceptedModel>> CumulativeTaxDataDownload(
            string bearerToken, string acceptId, CumulativeTaxDataDownloadRequestModel requestModel,
            TimeSpan? timeout = null, CancellationToken cancellationToken = default)
        {
            return TaxContract.CumulativeTaxDataDownload(bearerToken, requestModel.SuodeYuefen, acceptId, requestModel, timeout, cancellationToken);
        }

        /// <summary>
        /// 累计算税数据下载查询 <see cref="ITaxContract.GetCumulativeTaxData"/>
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="ljssAcceptId">累计算税数据下载任务受理ID</param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public ITask<Response<CumulativeTaxDataResponseModel>> GetCumulativeTaxData(
            string bearerToken, string ljssAcceptId, TimeSpan? timeout = null, CancellationToken cancellationToken = default)
        {
            return TaxContract.GetCumulativeTaxData(bearerToken, ljssAcceptId, timeout, cancellationToken);
        }

        /// <summary>
        /// 个税申报服务 <see cref="ITaxContract.TaxDeclaration"/>
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="requestModel"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        public ITask<Response<BusinessAcceptedModel>> TaxDeclaration(
            string bearerToken, TaxDeclarationRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default)
        {
            return TaxContract.TaxDeclaration(bearerToken, requestModel, timeout, cancellationToken);
        }

        /// <summary>
        /// 个税申报状态查询服务 <see cref="ITaxContract.GetTaxDeclarationResults"/>
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="sbrwAcceptId">申报任务受理ID</param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public ITask<Response<TaxDeclarationStatusResponseModel>> GetTaxDeclarationResults(
            string bearerToken, string sbrwAcceptId, TimeSpan? timeout = null, CancellationToken cancellationToken = default)
        {
            return TaxContract.GetTaxDeclarationResults(bearerToken, sbrwAcceptId, timeout, cancellationToken);
        }

        /// <summary>
        /// 个税申报反馈服务 <see cref="ITaxContract.TaxDeclarationFeedback"/>
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="sbrwAcceptId">申报任务受理ID</param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        ITask<Response<BusinessAcceptedModel>> TaxDeclarationFeedback(
            string bearerToken, string sbrwAcceptId, TimeSpan? timeout = null, CancellationToken cancellationToken = default)
        {
            return TaxContract.TaxDeclarationFeedback(bearerToken, sbrwAcceptId, timeout, cancellationToken);
        }

        /// <summary>
        /// 个税申报反馈状态查询服务 <see cref="ITaxContract.GetTaxDeclarationFeedbackResults"/>
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="sbfkrwAcceptId">申报反馈任务受理ID</param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        ITask<Response<TaxDeclarationStatusResponseModel>> GetTaxDeclarationFeedbackResults(
            string bearerToken, string sbfkrwAcceptId, TimeSpan? timeout = null, CancellationToken cancellationToken = default)
        {
            return TaxContract.GetTaxDeclarationFeedbackResults(bearerToken, sbfkrwAcceptId, timeout, cancellationToken);
        }

        /// <summary>
        /// 个数申报作废状态查询服务 <see cref="ITaxContract.GetTaxDeclarationCancelResults"/>
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="zfrwAcceptId">作废任务受理ID</param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        ITask<Response<TaxDeclarationCancelStatusResponseModel>> GetTaxDeclarationCancelResults(
            string bearerToken, string zfrwAcceptId, TimeSpan? timeout = null, CancellationToken cancellationToken = default)
        {
            return TaxContract.GetTaxDeclarationCancelResults(bearerToken, zfrwAcceptId, timeout, cancellationToken);
        }
    }
}
