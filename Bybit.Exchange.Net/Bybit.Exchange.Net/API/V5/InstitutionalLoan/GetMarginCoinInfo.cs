using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.InstitutionalLoan;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class InstitutionalLoan
            {
                private string GetMarginCoinInfoUrl { get; set; } = "/v5/ins-loan/ensure-tokens-convert";

                public async Task<BybitResponse<GetMarginCoinInfoResponse>> GetMarginCoinInfoAsync(GetMarginCoinInfoRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetMarginCoinInfoUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: true);
                    var results = Utils.GetResponse<GetMarginCoinInfoResponse>(response);
                    return results;
                }
            }
        }
    }
}
