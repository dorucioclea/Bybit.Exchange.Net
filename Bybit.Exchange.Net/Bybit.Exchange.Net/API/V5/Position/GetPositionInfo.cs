using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Position;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Position
            {
                private string GetPositionInfoUrl { get; set; } = "/v5/position/list";

                public async Task<BybitResponse<GetPositionInfoResponse>> GetPositionInfoAsync(GetPositionInfoRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetPositionInfoUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<GetPositionInfoResponse>(response);
                    return results;
                }
            }
        }
    }
}