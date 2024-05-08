using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Account;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Account
            {
                private string DemoApplyMoneyUrl { get; set; } = "/v5/account/demo-apply-money";

                public async Task<BybitResponse<DemoApplyMoneyResponse>> DemoApplyMoneyAsync(DemoApplyMoneyRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, DemoApplyMoneyUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<DemoApplyMoneyResponse>(response);
                    return results;
                }
            }
        }
    }
}