﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/game/wallet/game_pay 接口的响应。</para>
    /// </summary>
    public class AppsGameWalletGamePayResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string BillNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置预扣后的余额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int Balance { get; set; }

        /// <summary>
        /// 获取或设置本次扣除赠送的游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("used_gen_amt")]
        [System.Text.Json.Serialization.JsonPropertyName("used_gen_amt")]
        public int UsedGenAmount { get; set; }
    }
}
