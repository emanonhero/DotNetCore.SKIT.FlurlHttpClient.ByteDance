namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/fulfilment/certificate/prepare 接口的请求。</para>
    /// </summary>
    public class GoodLifeFulfilmentCertificatePrepareV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string? POIId { get; set; }

        /// <summary>
        /// 获取或设置加密券码解析数据。与字段 <see cref="Code"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? EncryptedData { get; set; }

        /// <summary>
        /// 获取或设置券码。与字段 <see cref="EncryptedData"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Code { get; set; }
    }
}
