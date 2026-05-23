using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models;

/// <summary>
/// https://open.douyin.com/goodlife/v1/goods/open/common/product/poi/operate/ 请求
/// </summary>
public class GoodLifeGoodsProductPoiOperateV1Request : DouyinOpenRequest
{

    public static class Types
    {
        /// <summary>
        /// 
        /// </summary>
        public class Context
        {
            /// <summary>
            /// 新增门店在已售卖订单是否可核销(点单不支持)
            /// </summary>
            [Newtonsoft.Json.JsonProperty("additional_poi_support_history")]
            [System.Text.Json.Serialization.JsonPropertyName("additional_poi_support_history")]
            public bool AdditionalPoiSupportHistory { get; set; } = true;

            /// <summary>
            /// 新增门店在已售卖订单是否可核销(点单不支持)
            /// </summary>
            [Newtonsoft.Json.JsonProperty("ignore_inapplicable_poi")]
            [System.Text.Json.Serialization.JsonPropertyName("ignore_inapplicable_poi")]
            public bool IgnoreInapplicablePoi { get; set; } = true;
        }
    }
    /// <summary>
    /// 获取或设置商家 ID。
    /// </summary>
    [Newtonsoft.Json.JsonProperty("account_id")]
    [System.Text.Json.Serialization.JsonPropertyName("account_id")]
    public string AccountId { get; set; } = string.Empty;

    /// <summary>
    /// 获取或设置商品 ID。与字段 <see cref="OutProductId"/> 二选一。
    /// </summary>
    [Newtonsoft.Json.JsonProperty("product_id")]
    [System.Text.Json.Serialization.JsonPropertyName("product_id")]
    public string? ProductId { get; set; }

    /// <summary>
    /// 获取或设置商品外部 ID。与字段 <see cref="ProductId"/> 二选一。
    /// </summary>
    [Newtonsoft.Json.JsonProperty("out_id")]
    [System.Text.Json.Serialization.JsonPropertyName("out_id")]
    public string? OutProductId { get; set; }

    /// <summary>
    /// 操作类型
    /// Add=1仅新增  Delete = 2 仅删除  Replace=3	覆盖。
    /// </summary>
    [Newtonsoft.Json.JsonProperty("poi_operate_type")]
    [System.Text.Json.Serialization.JsonPropertyName("poi_operate_type")]
    public int PoiOperateType { get; set; }

    /// <summary>
    /// 门店id列表
    /// </summary>
    [Newtonsoft.Json.JsonProperty("poi_id_list")]
    [System.Text.Json.Serialization.JsonPropertyName("poi_id_list")]
    public List<long> PoiIdList { get; set; } = new();

    /// <summary>
    /// 操作
    /// </summary>
    [Newtonsoft.Json.JsonProperty("context")]
    [System.Text.Json.Serialization.JsonPropertyName("context")]
    public Types.Context Context { get; set; } = new Types.Context();
}
