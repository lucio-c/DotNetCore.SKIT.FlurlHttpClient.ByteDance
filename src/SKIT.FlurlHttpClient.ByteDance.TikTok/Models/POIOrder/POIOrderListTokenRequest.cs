﻿namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/order/list/token 接口的请求。</para>
    /// </summary>
    public class POIOrderListTokenRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置订单日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OrderDateString { get; set; } = string.Empty;
    }
}
