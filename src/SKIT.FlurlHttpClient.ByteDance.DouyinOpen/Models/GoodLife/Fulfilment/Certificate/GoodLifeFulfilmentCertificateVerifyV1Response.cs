namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/fulfilment/certificate/verify 接口的响应。</para>
    /// </summary>
    public class GoodLifeFulfilmentCertificateVerifyV1Response : DouyinOpenResponse<GoodLifeFulfilmentCertificateVerifyV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class VerifyResult
                    {
                        public static class Types
                        {
                            public class Amount
                            {
                                /// <summary>
                                /// 获取或设置原始金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("original_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("original_amount")]
                                public int? OriginalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置用户实付金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                                public int? PayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置商家营销金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("merchant_ticket_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("merchant_ticket_amount")]
                                public int? MerchantTicketAmount { get; set; }

                                /// <summary>
                                /// 获取或设置划线价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("list_market_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("list_market_amount")]
                                public int? ListMarketAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_discount_amount")]
                                public int? PlatformDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置券实付金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("coupon_pay_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("coupon_pay_amount")]
                                public int? CouponPayAmount { get; set; }
                            }

                            public class TimesCardSerialAmount
                            {
                                /// <summary>
                                /// 获取或设置次序号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("serial_numb")]
                                [System.Text.Json.Serialization.JsonPropertyName("serial_numb")]
                                public int? SerialNumber { get; set; }

                                /// <summary>
                                /// 获取或设置对应次序号的金额信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                public Amount? Amount { get; set; }
                            }

                            public class BenefitAmount
                            {
                                /// <summary>
                                /// 获取或设置本金扣除金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("principal_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("principal_amount")]
                                public int? PrincipalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置赠送金扣除金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("benefit_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("benefit_amount")]
                                public int? BenefitValue { get; set; }

                                /// <summary>
                                /// 获取或设置总扣除金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                                public int? TotalAmount { get; set; }
                            }

                            public class VerifyAmountInfo
                            {
                                /// <summary>
                                /// 获取或设置对应核销序号的金额明细。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("times_card_serial_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("times_card_serial_amount")]
                                public TimesCardSerialAmount? TimesCardSerialAmount { get; set; }

                                /// <summary>
                                /// 获取或设置惠享卡核销信息（仅惠享卡核销返回）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("benefit_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("benefit_amount")]
                                public BenefitAmount? BenefitAmount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置验券结果码（0表示成功，非0表示失败）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("result")]
                        [System.Text.Json.Serialization.JsonPropertyName("result")]
                        public int ResultCode { get; set; }

                        /// <summary>
                        /// 获取或设置验券结果说明。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg")]
                        public string? ResultMessage { get; set; }

                        /// <summary>
                        /// 获取或设置券码（代表验券传入的 code 或 encrypted_code）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string? Code { get; set; }

                        /// <summary>
                        /// 获取或设置核销记录 ID（代表券码一次核销的标识）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify_id")]
                        public string? VerifyId { get; set; }

                        /// <summary>
                        /// 获取或设置订单 ID（代表一张订单的标识）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string? OrderId { get; set; }

                        /// <summary>
                        /// 获取或设置券码 ID（代表一张券码的标识，不等于券码但与券码一一对应）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                        public string? CertificateId { get; set; }

                        /// <summary>
                        /// 获取或设置券码编号（代表验券传入的 certificate_no_content）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_no")]
                        public string? CertificateNumber { get; set; }

                        /// <summary>
                        /// 获取或设置原始券码（代表抖音团购券的12位或15位原始券码）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("origin_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("origin_code")]
                        public string? OriginCode { get; set; }

                        /// <summary>
                        /// 获取或设置商家 ID（代表企业号商家总店 ID）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                        public string? AccountId { get; set; }

                        /// <summary>
                        /// 获取或设置项目唯一标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("project_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("project_id")]
                        public string? ProjectId { get; set; }

                        /// <summary>
                        /// 获取或设置身份证号（代表验券传入的 id_card_content）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_card")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_card")]
                        public string? IdCard { get; set; }

                        /// <summary>
                        /// 获取或设置二维码（代表验券传入的 qrcode_content）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qrcode")]
                        [System.Text.Json.Serialization.JsonPropertyName("qrcode")]
                        public string? QRCode { get; set; }

                        /// <summary>
                        /// 获取或设置核销金额信息（仅次卡核销返回）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify_amount_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify_amount_info")]
                        public Types.VerifyAmountInfo? VerifyAmountInfo { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置核销结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_results")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_results")]
                public Types.VerifyResult[] VerifyResultList { get; set; } = default!;
            }
        }
    }
}
