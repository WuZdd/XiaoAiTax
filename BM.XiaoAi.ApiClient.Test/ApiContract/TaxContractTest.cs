using BM.XiaoAi.ApiClient.ApiParameterModels.Generic;
using BM.XiaoAi.ApiClient.ApiParameterModels.Generic.Reduction;
using BM.XiaoAi.ApiClient.ApiParameterModels.Request;
using BM.XiaoAi.ApiClient.ApiParameterModels.Request.Auth;
using BM.XiaoAi.ApiClient.ApiParameterModels.Request.Tax;
using BM.XiaoAi.ApiClient.ApiParameterModels.Response;
using BM.XiaoAi.ApiClient.ApiParameterModels.Response.Auth;
using BM.XiaoAi.ApiClient.ApiParameterModels.Response.Tax;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using WebApiClient;
using Xunit;

namespace BM.XiaoAi.ApiClient.Test.ApiContract
{
    public class TaxContractTest : TestBase
    {
        private TokenSettings _tokenSettings;

        private readonly static object _locker = new object();

        public TokenSettings TokenSettings
        {
            get
            {
                if (_tokenSettings == null)
                {
                    if (File.Exists(TokenSettingFilePath))
                    {
                        _tokenSettings = JsonConvert.DeserializeObject<TokenSettings>(File.ReadAllText(TokenSettingFilePath));
                    }
                    else
                    {
                        _tokenSettings = new TokenSettings();

                        File.WriteAllText(TokenSettingFilePath, JsonConvert.SerializeObject(_tokenSettings));
                    }
                }

                if (_tokenSettings.CreationTime.AddSeconds(_tokenSettings.ExpiresIn - 300) <= DateTime.Now)
                {
                    lock (_locker)
                    {
                        _tokenSettings = JsonConvert.DeserializeObject<TokenSettings>(File.ReadAllText(TokenSettingFilePath));
                        if (_tokenSettings.CreationTime.AddSeconds(_tokenSettings.ExpiresIn - 300) <= DateTime.Now)
                        {
                            TokenResponseModel result;
                            if (string.IsNullOrEmpty(_tokenSettings.RefreshToken))
                            {
                                var requestModel = XiaoAiGlobal.GlobalConfig.DefaultXiaoAiClientSettings.CreateGetTokenRequestModel();
                                result = ApiFactory.CreateAuthClient().GetToken(requestModel).GetAwaiter().GetResult();
                            }
                            else
                            {
                                var requestModel = new RefreshTokenRequestModel { RefreshToken = _tokenSettings.RefreshToken };
                                result = ApiFactory.CreateAuthClient().RefreshToken(requestModel).GetAwaiter().GetResult();
                            }

                            if (result != null)
                            {
                                _tokenSettings = new TokenSettings
                                {
                                    AccessToken = $"{result.TokenType} {result.AccessToken}",
                                    RefreshToken = result.RefreshToken,
                                    ExpiresIn = result.ExpiresIn,
                                    CreationTime = DateTime.Now
                                };
                                File.WriteAllText(TokenSettingFilePath, JsonConvert.SerializeObject(_tokenSettings));
                            }
                        }
                    }
                }

                return _tokenSettings;
            }
        }

        /// <summary>
        /// 人员信息申报
        /// </summary>
        /// <param name="sdyf">所得月份</param>
        /// <returns></returns>
        [Theory]
        [InlineData("202010")]
        public async Task Ryxxbs_ReturnsAcceptId(string sdyf)
        {
            var taxSetting = XiaoAiGlobal.GlobalConfig.DefaultXiaoAiTaxSettings;
            var requestModel = new PersonnelInfoSubmissionRequestModel()
            {
                NashuirenShibiehao = taxSetting.ShuiHao,
                AreaId = taxSetting.Administrative,
                SuodeYuefen = sdyf,
                DengjiXuhaoId = taxSetting.DengjiXuhao,
                ShenbaoMima = taxSetting.ShenbaoMima,
                Taxpayers = new List<TaxpayerDetail>()
                {
                    new TaxpayerDetail
                    {
                        LicenseType = Enums.LicenseType.居民身份证,
                        LicenseNumber = "330421199712050024",
                        FullName = "赵静文",
                        Nationality = "中国",
                        Gender = "女",
                        BirthDate = "1997-12-05",
                        Status = "正常",
                        Mobile = "18868332178",
                        EmploymentType = Enums.EmploymentType.雇员,
                        EmployementDate = "2020-04-07"
                    },
                    new TaxpayerDetail
                    {
                        LicenseType = Enums.LicenseType.居民身份证,
                        LicenseNumber = "330402199107030931",
                        FullName = "傅岑超坚",
                        Nationality = "中国",
                        Gender = "男",
                        BirthDate = "1991-07-03",
                        Status = "正常",
                        Mobile = "13738269102",
                        EmploymentType = Enums.EmploymentType.雇员,
                        EmployementDate = "2019-01-01"
                    },
                    new TaxpayerDetail
                    {
                        LicenseType = Enums.LicenseType.居民身份证,
                        LicenseNumber = "520201198412270425",
                        FullName = "张莉莎",
                        Nationality = "中国",
                        Gender = "女",
                        BirthDate = "1984-12-27",
                        Status = "正常",
                        Mobile = "15068205522",
                        EmploymentType = Enums.EmploymentType.雇员,
                        EmployementDate = "2019-01-01"
                    },
                    new TaxpayerDetail
                    {
                        LicenseType = Enums.LicenseType.居民身份证,
                        LicenseNumber = "330424199801113823",
                        FullName = "徐鑫婷",
                        Nationality = "中国",
                        Gender = "女",
                        BirthDate = "1998-01-11",
                        Status = "正常",
                        Mobile = "18368387477",
                        EmploymentType = Enums.EmploymentType.雇员,
                        EmployementDate = "2019-03-18"
                    },
                    new TaxpayerDetail
                    {
                        LicenseType = Enums.LicenseType.居民身份证,
                        LicenseNumber = "330482199601192727",
                        FullName = "胡雪婷",
                        Nationality = "中国",
                        Gender = "女",
                        BirthDate = "1996-01-19",
                        Status = "正常",
                        Mobile = "18368387477",
                        EmploymentType = Enums.EmploymentType.雇员,
                        EmployementDate = "2019-07-24"
                    },
                    new TaxpayerDetail
                    {
                        LicenseType = Enums.LicenseType.居民身份证,
                        LicenseNumber = "341126199710206345",
                        FullName = "张颖",
                        Nationality = "中国",
                        Gender = "女",
                        BirthDate = "1997-10-20",
                        Status = "正常",
                        Mobile = "13511392241",
                        EmploymentType = Enums.EmploymentType.雇员,
                        EmployementDate = "2019-03-18"
                    }
                }
            };
            requestModel.ZongRenshu = requestModel.Taxpayers.Count;

            Response<BusinessAcceptedModel> result = await ApiFactory.CreateTaxClient().PersonnelSubmission(TokenSettings.AccessToken, requestModel);

            Assert.NotNull(result);
            Assert.True(result.ExistsBusinessResponseContent);
            Assert.NotEmpty(result.BusinessResponseContent.AcceptId);
        }

        /// <summary>
        /// 人员信息报送状态查询
        /// </summary>
        /// <param name="acceptId">报送任务受理ID</param>
        /// <returns></returns>
        [Theory]
        [InlineData("20201015163904-9305-387474638093029376")]
        public async Task Ryxxbscx_ReturnsTaxpayersInfo(string acceptId)
        {
            Response<PersionnelSubmissionStatusResponseModel> result =
                await ApiFactory.CreateTaxClient().GetPersonnelSubmissionResults(TokenSettings.AccessToken, acceptId)
                .Retry(3, TimeSpan.FromSeconds(5))
                .WhenCatch<HttpStatusFailureException>(ex => ex.StatusCode == System.Net.HttpStatusCode.RequestTimeout)
                .WhenResult(p => p != null && "0700".Equals(p.ResultCode));

            Assert.NotNull(result);
            Assert.True(result.ExistsBusinessResponseContent);
        }

        [Theory]
        [InlineData("202010", "20201015163904-9305-387474638093029376")]
        public async Task Skjs_ReturnsAcceptId(string sdyf, string acceptId) 
        {
            var taxSetting = XiaoAiGlobal.GlobalConfig.DefaultXiaoAiTaxSettings;
            var requestModel = new TaxCalculationRequestModel
            {
                NashuirenShibiehao = taxSetting.ShuiHao,
                AreaId = taxSetting.Administrative,
                SuodeYuefen = sdyf,
                DengjiXuhaoId = taxSetting.DengjiXuhao,
                ShenbaoMima = taxSetting.ShenbaoMima,
                Data = new IncomeData
                {
                    YukouYujiao = new YukouYujiao
                    {
                        ZhengchangGongziXinjinLiebiao = new List<PersonalNormalSalaryInfo>()
                        {
                            new PersonalNormalSalaryInfo
                            {
                                LicenseType = Enums.LicenseType.居民身份证,
                                LicenseNumber = "330421199712050024",
                                FullName = "赵静文",
                                Shourue = 10000,
                                JibenYanglaoBaoxian = 500,
                                JibenYiliaoBaoxian = 200,
                                JianmianShuie = 10
                            }
                        },
                        JianmianShixiangFubiaoLiebiao = new List<ReductionItemSchedule>() 
                        { 
                            new ReductionItemSchedule
                            {
                                LicenseType = Enums.LicenseType.居民身份证,
                                LicenseNumber = "330421199712050024",
                                FullName = "赵静文",
                                JianmianFangshi = 0,
                                SuodeXiangmu = Enums.IncomeItem.正常工资薪金,
                                JianmianShixiang = "残疾、孤老、烈属减征个人所得税",
                                JianmianXingzhi = "《中华人民共和国个人所得税法》 中华人民共和国主席令第48号第五条第一项",
                                JianmianJinE = 10
                            }
                        }
                    }
                }
            };

            Response<BusinessAcceptedModel> result = await ApiFactory.CreateTaxClient().TaxCalculation(TokenSettings.AccessToken, requestModel, acceptId);

            Assert.NotNull(result);
            Assert.True(result.ExistsBusinessResponseContent);
            Assert.NotEmpty(result.BusinessResponseContent.AcceptId);
        }

        [Theory]
        [InlineData("20201015170843-9307-387482100720205824")]
        public async Task Skjscx_ReturnsTaxCalculationResult(string skjsAcceptId) 
        {
            Response<TaxCalculationResponseModel> result = await ApiFactory.CreateTaxClient().GetTaxCalculationResults(TokenSettings.AccessToken, skjsAcceptId)
                .Retry(3, TimeSpan.FromSeconds(10))
                .WhenCatch<HttpStatusFailureException>(ex => ex.StatusCode == System.Net.HttpStatusCode.RequestTimeout)
                .WhenResult(p => p != null && "0700".Equals(p.ResultCode));

            Assert.NotNull(result);
            Assert.True(result.ExistsBusinessResponseContent);
        }

        [Theory]
        [InlineData("202010", "20201015163904-9305-387474638093029376")]
        public async Task Ljsssjxz_ReturnsAcceptId(string sdyf, string acceptId)
        {
            var taxSetting = XiaoAiGlobal.GlobalConfig.DefaultXiaoAiTaxSettings;
            var requestModel = new CumulativeTaxDataDownloadRequestModel
            {
                NashuirenShibiehao = taxSetting.ShuiHao,
                AreaId = taxSetting.Administrative,
                SuodeYuefen = sdyf,
                DengjiXuhaoId = taxSetting.DengjiXuhao,
                ShenbaoMima = taxSetting.ShenbaoMima,
                XiazaiZhuanxiangXinxi = true,
            };

            Response<BusinessAcceptedModel> result = await ApiFactory.CreateTaxClient().CumulativeTaxDataDownload(TokenSettings.AccessToken, acceptId, requestModel);

            Assert.NotNull(result);
            Assert.True(result.ExistsBusinessResponseContent);
        }

        [Theory]
        [InlineData("20201016091528-9324-387725389885079552")]
        public async Task Ljsssjxzcx_ReturnsPersonalNormalSalaryInfo(string ljssAcceptId) 
        {
            Response<CumulativeTaxDataResponseModel> result = await ApiFactory.CreateTaxClient().GetCumulativeTaxData(TokenSettings.AccessToken, ljssAcceptId)
                .Retry(3, TimeSpan.FromSeconds(10))
                .WhenCatch<HttpStatusFailureException>(ex => ex.StatusCode == System.Net.HttpStatusCode.RequestTimeout)
                .WhenResult(p => p != null && "0700".Equals(p.ResultCode));

            Assert.NotNull(result);
            Assert.True(result.ExistsBusinessResponseContent);
        }
    }
}