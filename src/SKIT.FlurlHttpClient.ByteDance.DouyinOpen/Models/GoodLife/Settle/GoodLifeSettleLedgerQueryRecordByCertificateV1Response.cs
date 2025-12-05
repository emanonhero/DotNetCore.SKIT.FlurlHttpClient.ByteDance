namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/settle/ledger/query_record_by_cert 接口的响应。</para>
    /// </summary>
    public class GoodLifeSettleLedgerQueryRecordByCertificateV1Response : DouyinOpenResponse<GoodLifeSettleLedgerQueryRecordByCertificateV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class LedgerRecord
                    {
                        public static class Types
                        {
                            public class Amount
                            {
                                public static class Types
                                {
                                    public class SettleAmount
                                    {
                                        /// <summary>
                                        /// 券原始金额（单位：分），交易金额、订单实收。等于抖音平台补贴＋用户实付金额＋商家优惠金额。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("original")]
                                        [System.Text.Json.Serialization.JsonPropertyName("original")]
                                        public int OriginalAmount { get; set; }

                                        /// <summary>
                                        /// 用户实付金额（单位：分）。包含支付渠道优惠的金额。示例：用户使用抖音支付，银行卡扣款 99.4 元，抖音支付优惠 0.6 元，此处返回用户实付金额=100 元。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("pay")]
                                        [System.Text.Json.Serialization.JsonPropertyName("pay")]
                                        public int PayAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置商家营销金额（单位：分）。商家优惠补贴（该部分金额无需参与与结算）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("merchant_ticket")]
                                        [System.Text.Json.Serialization.JsonPropertyName("merchant_ticket")]
                                        public int MerchantTicketAmount { get; set; }

                                        /// <summary>
                                        /// 实付保险费用（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("actual_insured")]
                                        [System.Text.Json.Serialization.JsonPropertyName("actual_insured")]
                                        public int ActualInsuredAmount { get; set; }

                                        /// <summary>
                                        /// 代运营服务商总佣金（单位：分）。非合并计算时等于服务商佣金；需要合并计算时等于服务商佣金＋达人佣金。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("total_operation_agent")]
                                        [System.Text.Json.Serialization.JsonPropertyName("total_operation_agent")]
                                        public int TotalOperationAgentCommission { get; set; }

                                        /// <summary>
                                        /// 获取或设置公益捐赠金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("welfare_donation")]
                                        [System.Text.Json.Serialization.JsonPropertyName("welfare_donation")]
                                        public int WelfareDonationAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置平台推广费（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("zlb_promotion_fee")]
                                        [System.Text.Json.Serialization.JsonPropertyName("zlb_promotion_fee")]
                                        public int PlatformPromotionFee { get; set; }

                                        /// <summary>
                                        /// 获取或设置应结算金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ledger_total")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ledger_total")]
                                        public int LedgerTotalAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置品牌商补贴金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("brand_funder_subsidy")]
                                        [System.Text.Json.Serialization.JsonPropertyName("brand_funder_subsidy")]
                                        public int BrandFunderSubsidyAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置团购券抵扣金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("deduction_discount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("deduction_discount")]
                                        public int DeductionDiscountAmount { get; set; }
                                    }

                                    public class FundAmount
                                    {
                                        /// <summary>
                                        /// 获取或设置佣金汇总金额（单位：分）。包含平台佣金和所有达人服务费佣金金额。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("total_commission")]
                                        [System.Text.Json.Serialization.JsonPropertyName("total_commission")]
                                        public int TotalCommission { get; set; }

                                        /// <summary>
                                        /// 获取或设置达人佣金（单位：分）。包含星图达人、税筹达人、机构达人和非机构达人。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("talent_commission")]
                                        [System.Text.Json.Serialization.JsonPropertyName("talent_commission")]
                                        public int TalentCommission { get; set; }

                                        /// <summary>
                                        /// 获取或设置商家货款金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("goods")]
                                        [System.Text.Json.Serialization.JsonPropertyName("goods")]
                                        public int GoodsAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置支付手续费（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("pay_handling")]
                                        [System.Text.Json.Serialization.JsonPropertyName("pay_handling")]
                                        public int PayHandlingAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置代理商佣金（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("proxy_commission")]
                                        [System.Text.Json.Serialization.JsonPropertyName("proxy_commission")]
                                        public int ProxyCommission { get; set; }

                                        /// <summary>
                                        /// 获取或设置服务商分佣总金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("total_agent_merchant")]
                                        [System.Text.Json.Serialization.JsonPropertyName("total_agent_merchant")]
                                        public int TotalAgentMerchantCommission { get; set; }

                                        /// <summary>
                                        /// 获取或设置软件服务费（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("total_merchant_platform_service")]
                                        [System.Text.Json.Serialization.JsonPropertyName("total_merchant_platform_service")]
                                        public int SoftwareServiceFee { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置分账单金额信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                public Types.SettleAmount SettleAmount { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置分账款项金额信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("fund_amount")]
                                public Types.FundAmount FundAmount { get; set; } = default!;
                            }

                            public class SKU
                            {
                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商家系统（第三方）商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("third_sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("third_sku_id")]
                                public string? ThirdSKUId { get; set; }

                                /// <summary>
                                /// 获取或设置团购名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置团购市场价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("market_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("market_price")]
                                public int MarketPrice { get; set; }

                                /// <summary>
                                /// 获取或设置售卖开始时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sold_start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("sold_start_time")]
                                public long StartTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置游标。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cursor")]
                        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                        public string Cursor { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分账记录 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ledger_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ledger_id")]
                        public string LedgerId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置核销记录 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify_id")]
                        public string VerifyId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                        public string CertificateId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置核销时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify_time")]
                        public long VerifyTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置券码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string Code { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public Types.Amount Amount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否是商场模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_mall_store")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_mall_store")]
                        public bool? IsMallStore { get; set; }

                        /// <summary>
                        /// 获取或设置团购 SKU 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku")]
                        public Types.SKU SKU { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置分账记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("records")]
                [System.Text.Json.Serialization.JsonPropertyName("records")]
                public Types.LedgerRecord[] LedgerRecordList { get; set; } = default!;

            }
        }
    }
}
