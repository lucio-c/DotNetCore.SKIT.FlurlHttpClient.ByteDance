﻿namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/order/status 接口的请求。</para>
    /// </summary>
    public class POIOrderStatusRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置外部订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_ext_id")]
        public string OrderExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接入方店铺外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
        public string SupplierExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单确认状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
