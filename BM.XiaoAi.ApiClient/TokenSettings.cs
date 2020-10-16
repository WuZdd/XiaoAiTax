using System;

namespace BM.XiaoAi.ApiClient
{
    /// <summary>
    /// token配置
    /// </summary>
    public class TokenSettings
    {
        /// <summary>
        /// 访问令牌
        /// <para>后续访问其他API必须要带的</para>
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// 刷新令牌
        /// <para>用于access_token过期时通过刷新重新获取access_token</para>
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// 过期时间（单位：秒）
        /// </summary>
        public int ExpiresIn { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; } = DateTime.Now;
    }
}
