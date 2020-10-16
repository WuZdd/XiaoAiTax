using BM.XiaoAi.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.XiaoAi.ApiClient.ApiParameterModels.Response
{
    /// <summary>
    /// 响应模型
    /// </summary>
    public abstract class ResponseModel : ApiParameterModelBase
    {
        /// <summary>
        /// 返回状态
        /// </summary>
        [ApiParameterName("code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [ApiParameterName("msg")]
        public string Message { get; set; }
    }
}
