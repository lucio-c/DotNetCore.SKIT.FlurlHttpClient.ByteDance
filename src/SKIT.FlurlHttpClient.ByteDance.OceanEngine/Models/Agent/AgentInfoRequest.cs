﻿using System;
using System.Collections.Generic;

/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/agent/info 接口的请求。</para>
    /// </summary>
    public class AgentInfoRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置代理商 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_ids")]
        public IList<long> AgentIdList { get; set; } = new List<long>();

        /// <summary>
        /// 获取或设置查询字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fields")]
        [System.Text.Json.Serialization.JsonPropertyName("fields")]
        public IList<string>? FieldList { get; set; }
    }
}
