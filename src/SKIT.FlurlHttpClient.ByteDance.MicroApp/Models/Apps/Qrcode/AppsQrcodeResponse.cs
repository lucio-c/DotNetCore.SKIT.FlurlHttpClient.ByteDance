﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/qrcode 接口的响应。</para>
    /// </summary>
    public class AppsQrcodeResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// 获取或设置会话密钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("session_key")]
        [System.Text.Json.Serialization.JsonPropertyName("session_key")]
        public string? SessionKey { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置匿名用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anonymous_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("anonymous_openid")]
        public string? AnonymousOpenId { get; set; }

        /// <summary>
        /// 获取或设置用户的 UnionId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string? UnionId { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && RawBytes?.Length > 0;
        }
    }
}
