namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models;

/// <summary>
/// https://open.douyin.com/goodlife/v1/goods/open/common/product/poi/operate/ 响应
/// </summary>
public class GoodLifeGoodsProductPoiOperateV1Response : DouyinOpenResponse<GoodLifeGoodsProductOperateV1Response.Types.Data>
{
    public static class Types
    {
        public class Data : DouyinOpenResponseData
        {
        }
    }
}
