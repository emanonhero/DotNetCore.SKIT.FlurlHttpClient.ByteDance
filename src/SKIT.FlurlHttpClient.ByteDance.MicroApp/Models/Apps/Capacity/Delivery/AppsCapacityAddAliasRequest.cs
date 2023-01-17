namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/add_alias 接口的请求。</para>
    /// </summary>
    public class AppsCapacityAddAliasRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序别名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias")]
        [System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string Alias { get; set; } = string.Empty;
    }
}
