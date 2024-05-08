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
                private string SetLeverageUrl { get; set; } = "/v5/position/set-leverage";

                public async Task<BybitResponse<SetLeverageResponse>> SetLeverageAsync(SetLeverageRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, SetLeverageUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<SetLeverageResponse>(response);
                    return results;
                }
            }
        }
    }
}