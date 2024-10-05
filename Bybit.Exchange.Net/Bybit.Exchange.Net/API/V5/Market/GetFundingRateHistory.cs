using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Market;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Market
            {
                private string GetFundingRateHistoryUrl { get; set; } = "/v5/market/funding/history";

                public async Task<BybitResponse<GetFundingRateHistoryResponse>> GetFundingRateHistoryAsync(GetFundingRateHistoryRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetFundingRateHistoryUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                    var results = Utils.GetResponse<GetFundingRateHistoryResponse>(response);
                    return results;
                }
            }
        }
    }
}