namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/fulfilment/certificate/prepare 接口的响应。</para>
    /// </summary>
    public class GoodLifeFulfilmentCertificatePrepareV1Response : DouyinOpenResponse<GoodLifeFulfilmentCertificatePrepareV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Certificate
                    {
                        public static class Types
                        {
                            public class Amount
                            {
                                /// <summary>
                                /// 获取或设置券原始金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("original_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("original_amount")]
                                public int OriginalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置用户实付金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                                public int PayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置品牌优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("brand_ticket_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("brand_ticket_amount")]
                                public long? BrandTicketAmount { get; set; }

                                /// <summary>
                                /// 获取或设置券码应付（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("coupon_pay_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("coupon_pay_amount")]
                                public int? CouponPayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置券划线价金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("list_market_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("list_market_amount")]
                                public int? ListMarketAmount { get; set; }

                                /// <summary>
                                /// 获取或设置商家营销金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("merchant_ticket_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("merchant_ticket_amount")]
                                public int? MerchantTicketAmount { get; set; }

                                /// <summary>
                                /// 获取或设置原币种划线价。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("origin_list_market_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("origin_list_market_amount")]
                                public long? OriginListMarketAmount { get; set; }

                                /// <summary>
                                /// 获取或设置原币种。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("original_currency")]
                                [System.Text.Json.Serialization.JsonPropertyName("original_currency")]
                                public string? OriginalCurrency { get; set; }

                                /// <summary>
                                /// 获取或设置支付优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("payment_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("payment_discount_amount")]
                                public int? PaymentDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_discount_amount")]
                                public int? PlatformDiscountAmount { get; set; }
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
                                /// 获取或设置团购名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置团购类型（type=1团餐券; type=2代金券; type=3次卡）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("groupon_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("groupon_type")]
                                public int GrouponType { get; set; }

                                /// <summary>
                                /// 获取或设置券类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("voucher_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("voucher_type")]
                                public int? VoucherType { get; set; }

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

                                /// <summary>
                                /// 获取或设置产品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public string? ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置产品外部 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_out_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_out_id")]
                                public string? ProductOutId { get; set; }

                                /// <summary>
                                /// 获取或设置供应商产品外部 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("suplier_product_out_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("suplier_product_out_id")]
                                public string? SupplierProductOutId { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 外部 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("third_sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("third_sku_id")]
                                public string? OutSKUId { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 外部 ID（新字段）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_out_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_out_id")]
                                public string? SKUOutId { get; set; }

                                /// <summary>
                                /// 获取或设置券商家团购账号 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("account_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                                public string? AccountId { get; set; }
                            }

                            public class DeductionInfo
                            {
                                /// <summary>
                                /// 获取或设置来源订单金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("source_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("source_amount")]
                                public long? SourceAmount { get; set; }

                                /// <summary>
                                /// 获取或设置来源订单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("source_order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("source_order_id")]
                                public string? SourceOrderId { get; set; }

                                /// <summary>
                                /// 获取或设置团购类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("groupon_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("groupon_type")]
                                public int? GrouponType { get; set; }

                                /// <summary>
                                /// 获取或设置券类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("voucher_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("voucher_type")]
                                public int? VoucherType { get; set; }

                                /// <summary>
                                /// 获取或设置来源券码 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("source_certificate_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("source_certificate_id")]
                                public string? SourceCertificateId { get; set; }
                            }

                            public class TimePeriod
                            {
                                /// <summary>
                                /// 获取或设置开始时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                                public string StartTime { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置结束时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                public string EndTime { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置结束时间是否是下一天。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_time_is_next_day")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_time_is_next_day")]
                                public bool? IsEndTimeNextDay { get; set; }
                            }

                            public class UseTimeInfo
                            {
                                /// <summary>
                                /// 获取或设置时间类型（1=全天可用; 2=特殊时段）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("use_time_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("use_time_type")]
                                public int UseTimeType { get; set; }

                                /// <summary>
                                /// 获取或设置时间段列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time_period_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("time_period_list")]
                                public TimePeriod[]? TimePeriodList { get; set; }
                            }

                            public class DailyTimeRange
                            {
                                /// <summary>
                                /// 获取或设置结束时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                public string? EndTime { get; set; }

                                /// <summary>
                                /// 获取或设置结束时间是否是下一天。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_time_is_next_day")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_time_is_next_day")]
                                public bool? IsEndTimeNextDay { get; set; }

                                /// <summary>
                                /// 获取或设置开始时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                                public string? StartTime { get; set; }
                            }

                            public class OffPeakTimeRange
                            {
                                /// <summary>
                                /// 获取或设置每日时间范围列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("daily_time_range_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("daily_time_range_list")]
                                public DailyTimeRange[]? DailyTimeRangeList { get; set; }

                                /// <summary>
                                /// 获取或设置星期列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("week_day_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("week_day_list")]
                                public int[]? WeekDayList { get; set; }

                                /// <summary>
                                /// 获取或设置开始时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                                public long? StartTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置结束时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                public long? EndTimestamp { get; set; }
                            }

                            public class OffPeakDiscountInfo
                            {
                                /// <summary>
                                /// 获取或设置错峰时间范围。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("off_peak_time_range")]
                                [System.Text.Json.Serialization.JsonPropertyName("off_peak_time_range")]
                                public OffPeakTimeRange[]? OffPeakTimeRangeList { get; set; }

                                /// <summary>
                                /// 获取或设置闲时限制类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("idle_time_limit_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("idle_time_limit_type")]
                                public int? IdleTimeLimitType { get; set; }

                                /// <summary>
                                /// 获取或设置是否有错峰优惠。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("has_off_peak_discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("has_off_peak_discount")]
                                public bool? HasOffPeakDiscount { get; set; }
                            }

                            public class PeriodCard
                            {
                                /// <summary>
                                /// 获取或设置周期卡类型（1=普通次卡; 2=阶梯次卡）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("period_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("period_type")]
                                public int? PeriodType { get; set; }
                            }

                            public class PayBillInfo
                            {
                                /// <summary>
                                /// 获取或设置买单总金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("bill_total_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("bill_total_amount")]
                                public long? BillTotalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置买单金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("bill_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("bill_amount")]
                                public long? BillAmount { get; set; }
                            }

                            public class SerialAmount
                            {
                                /// <summary>
                                /// 获取或设置次序号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("serial_numb")]
                                [System.Text.Json.Serialization.JsonPropertyName("serial_numb")]
                                public int SerialNumber { get; set; }

                                /// <summary>
                                /// 获取或设置对应次序号的金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                public Amount? Amount { get; set; }
                            }

                            public class TimeCard
                            {
                                /// <summary>
                                /// 获取或设置当前券所有次序号对应的金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("serial_amount_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("serial_amount_list")]
                                public SerialAmount[]? SerialAmountList { get; set; }

                                /// <summary>
                                /// 获取或设置次卡类型（1=普通次卡; 2=阶梯次卡）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time_card_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("time_card_type")]
                                public int? TimeCardType { get; set; }

                                /// <summary>
                                /// 获取或设置次卡总次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("times_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("times_count")]
                                public int? TimesCount { get; set; }

                                /// <summary>
                                /// 获取或设置次卡使用次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("times_used")]
                                [System.Text.Json.Serialization.JsonPropertyName("times_used")]
                                public int? TimesUsed { get; set; }
                            }

                            public class BuyerReserveInfo
                            {
                                /// <summary>
                                /// 获取或设置姓名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string? Name { get; set; }

                                /// <summary>
                                /// 获取或设置证件号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("credential_numb")]
                                [System.Text.Json.Serialization.JsonPropertyName("credential_numb")]
                                public string? CredentialNumber { get; set; }

                                /// <summary>
                                /// 获取或设置证件类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("credential_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("credential_type")]
                                public long? CredentialType { get; set; }
                            }

                            public class TimeDetail
                            {
                                /// <summary>
                                /// 获取或设置时间类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("time_type")]
                                public int? TimeType { get; set; }

                                /// <summary>
                                /// 获取或设置时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time")]
                                [System.Text.Json.Serialization.JsonPropertyName("time")]
                                public long? Time { get; set; }
                            }

                            public class AdvancePurchaseStruct
                            {
                                /// <summary>
                                /// 获取或设置购买类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("purchase_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("purchase_type")]
                                public int? PurchaseType { get; set; }

                                /// <summary>
                                /// 获取或设置时间详情。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time_detail")]
                                [System.Text.Json.Serialization.JsonPropertyName("time_detail")]
                                public TimeDetail[]? TimeDetailList { get; set; }
                            }

                            public class BenefitAmount
                            {
                                /// <summary>
                                /// 获取或设置优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("benefit_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("benefit_amount")]
                                public long? BenefitValue { get; set; }

                                /// <summary>
                                /// 获取或设置总金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                                public long? TotalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置本金金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("principal_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("principal_amount")]
                                public long? PrincipalAmount { get; set; }
                            }

                            public class BenefitCardInfo
                            {
                                /// <summary>
                                /// 获取或设置剩余金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("left_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("left_amount")]
                                public BenefitAmount? LeftAmount { get; set; }

                                /// <summary>
                                /// 获取或设置总金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                                public BenefitAmount? TotalAmount { get; set; }
                            }

                            public class BookInfo
                            {
                                /// <summary>
                                /// 获取或设置核销金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("verify_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("verify_amount")]
                                public long? VerifyAmount { get; set; }

                                /// <summary>
                                /// 获取或设置预约门店 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("book_poi_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("book_poi_id")]
                                public string? BookPoiId { get; set; }

                                /// <summary>
                                /// 获取或设置预约商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("book_product_number")]
                                [System.Text.Json.Serialization.JsonPropertyName("book_product_number")]
                                public long? BookProductNumber { get; set; }
                            }

                            public class OrderReserveUserInfo
                            {
                                /// <summary>
                                /// 获取或设置证件号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("credential_numb")]
                                [System.Text.Json.Serialization.JsonPropertyName("credential_numb")]
                                public string? CredentialNumber { get; set; }

                                /// <summary>
                                /// 获取或设置证件类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("credential_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("credential_type")]
                                public int? CredentialType { get; set; }

                                /// <summary>
                                /// 获取或设置姓名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string? Name { get; set; }

                                /// <summary>
                                /// 获取或设置手机号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phone")]
                                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                                public string? PhoneNumber { get; set; }
                            }

                            public class ReserveInfo
                            {
                                /// <summary>
                                /// 获取或设置订单维度的用户留资信息列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_reserve_user_info_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_reserve_user_info_list")]
                                public OrderReserveUserInfo[]? OrderReserveUserInfoList { get; set; }
                            }

                            public class DateRange
                            {
                                /// <summary>
                                /// 获取或设置开始时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                                public long? StartTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置结束时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                public long? EndTimestamp { get; set; }
                            }

                            public class NotAvailableTimeInfo
                            {
                                /// <summary>
                                /// 获取或设置是否可核销。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fulfil_enable")]
                                [System.Text.Json.Serialization.JsonPropertyName("fulfil_enable")]
                                public bool? IsFulfilEnabled { get; set; }

                                /// <summary>
                                /// 获取或设置不可用星期列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("can_no_use_week_day")]
                                [System.Text.Json.Serialization.JsonPropertyName("can_no_use_week_day")]
                                public long[]? CanNotUseWeekDayList { get; set; }

                                /// <summary>
                                /// 获取或设置不可用日期范围列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("can_no_use_date")]
                                [System.Text.Json.Serialization.JsonPropertyName("can_no_use_date")]
                                public DateRange[]? CanNotUseDateList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public Types.Amount Amount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置加密券码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("encrypted_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("encrypted_code")]
                        public string EncryptedCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置团购 SKU 信息（组合券包场景返回子品信息）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku")]
                        public Types.SKU SKU { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置凭证附加信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("additional_map")]
                        [System.Text.Json.Serialization.JsonPropertyName("additional_map")]
                        public System.Collections.Generic.IDictionary<string, string>? AdditionalMap { get; set; }

                        /// <summary>
                        /// 获取或设置提前购买规则（非错峰特惠才会返回）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advance_purchase_struct")]
                        [System.Text.Json.Serialization.JsonPropertyName("advance_purchase_struct")]
                        public Types.AdvancePurchaseStruct? AdvancePurchaseStruct { get; set; }

                        /// <summary>
                        /// 获取或设置惠享卡信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("benefit_card_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("benefit_card_info")]
                        public Types.BenefitCardInfo? BenefitCardInfo { get; set; }

                        /// <summary>
                        /// 获取或设置预约信息（目前用于提货券）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("book_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("book_info")]
                        public Types.BookInfo? BookInfo { get; set; }

                        /// <summary>
                        /// 获取或设置购买人留资信息（仅消费券需要验证实名的时候返回，否则为空）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_reserve_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_reserve_info")]
                        public Types.BuyerReserveInfo? BuyerReserveInfo { get; set; }

                        /// <summary>
                        /// 获取或设置券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                        public long? CertificateId { get; set; }

                        /// <summary>
                        /// 获取或设置券码（未核销时不返回、已核销可撤销时不返回）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string? Code { get; set; }

                        /// <summary>
                        /// 获取或设置抵扣信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deduction_info_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("deduction_info_list")]
                        public Types.DeductionInfo[]? DeductionInfoList { get; set; }

                        /// <summary>
                        /// 获取或设置券码有效期截止时间戳（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("expire_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                        public long? ExpireTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置不可用门店列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("not_available_poi_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("not_available_poi_list")]
                        public string[]? NotAvailablePoiList { get; set; }

                        /// <summary>
                        /// 获取或设置不可用时间信息（不包括开始时间和截止时间）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("not_available_time_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("not_available_time_info")]
                        public Types.NotAvailableTimeInfo? NotAvailableTimeInfo { get; set; }

                        /// <summary>
                        /// 获取或设置错峰优惠信息（核销准备接口返回）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("off_peak_discount_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("off_peak_discount_info")]
                        public Types.OffPeakDiscountInfo? OffPeakDiscountInfo { get; set; }

                        /// <summary>
                        /// 获取或设置买单信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_bill_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_bill_info")]
                        public Types.PayBillInfo? PayBillInfo { get; set; }

                        /// <summary>
                        /// 获取或设置周期卡信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("period_card")]
                        [System.Text.Json.Serialization.JsonPropertyName("period_card")]
                        public Types.PeriodCard? PeriodCard { get; set; }

                        /// <summary>
                        /// 获取或设置券留资信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reserve_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("reserve_info")]
                        public Types.ReserveInfo? ReserveInfo { get; set; }

                        /// <summary>
                        /// 获取或设置券码有效期开始时间戳（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                        public long? StartTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置券的状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int? Status { get; set; }

                        /// <summary>
                        /// 获取或设置次卡信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time_card")]
                        [System.Text.Json.Serialization.JsonPropertyName("time_card")]
                        public Types.TimeCard? TimeCard { get; set; }

                        /// <summary>
                        /// 获取或设置可用时间段信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("use_time_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("use_time_info")]
                        public Types.UseTimeInfo? UseTimeInfo { get; set; }

                        /// <summary>
                        /// 获取或设置核销类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("used_status_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("used_status_type")]
                        public int? UsedStatusType { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置一次验券的标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_token")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_token")]
                public string VerifyToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置抖音订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置可用团购券列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificates")]
                [System.Text.Json.Serialization.JsonPropertyName("certificates")]
                public Types.Certificate[] CertificateList { get; set; } = default!;
            }
        }
    }
}
