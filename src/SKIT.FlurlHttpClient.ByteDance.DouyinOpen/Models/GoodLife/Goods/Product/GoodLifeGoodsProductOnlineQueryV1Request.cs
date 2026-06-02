using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/goods/product/online/query 接口的请求。</para>
    /// </summary>
    public class GoodLifeGoodsProductOnlineQueryV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_id")]
        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string? AccountId { get; set; }

        /// <summary>
        /// 筛选在线状态，1-在线 2-下线 3-封禁
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// 第一页不传，之后用前一次返回的next_cursor传入进行翻页
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? PageCursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? PageSize { get; set; }

        /// <summary>
        /// 区分商品创建者的查询方式
        /// 0 - 查询服务商/开发者创建的商品,1 - 查询商家（account_id）创建的商品。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_creator_type")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_creator_type")]
        public int? GoodsCreatorType { get; set; }

        /// <summary>
        /// 新商品查询参数，使用goods_query_type这个的时候，goods_creator_type不生效
        /// 自研商家goods_query_type传2（自研商家可以查询全量商品，包含自研商家自己创建以及代运营或服务商等身份创建的商品）
        /// 服务商goods_query_type传3
        /// goods_query_type为1仅限餐饮KA商家可用，不推荐传1，可能会出现不返回信息的情况
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_query_type")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_query_type")]
        public int? GoodsQueryType { get; set; }

        /// <summary>
        /// 门店ID list，可支持最多传入100家门店
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_ids")]
        public List<long>? POIList { get; set; }

        /// <summary>
        /// 商品名称（长度不超过30，支持模糊搜索）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_name")]
        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
        public string? ProductName { get; set; }

        /// <summary>
        /// 是否查询商品全量关联门店设置为true时，分页数量最大上限为20
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_all_poi")]
        [System.Text.Json.Serialization.JsonPropertyName("query_all_poi")]
        public bool? QueryAllPoi { get; set; }
        
    }
}
