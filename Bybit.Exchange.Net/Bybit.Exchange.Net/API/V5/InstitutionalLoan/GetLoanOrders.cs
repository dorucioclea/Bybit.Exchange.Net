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
                private string GetLoanOrdersUrl { get; set; } = "/v5/ins-loan/loan-order";

                public async Task<BybitResponse<GetLoanOrdersResponse>> GetLoanOrdersAsync(GetLoanOrdersRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetLoanOrdersUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: true);
                    var results = Utils.GetResponse<GetLoanOrdersResponse>(response);
                    return results;
                }
            }
        }
    }
}
