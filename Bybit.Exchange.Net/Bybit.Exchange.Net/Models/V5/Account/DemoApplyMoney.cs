using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Account
{
    public class DemoApplyMoneyRequest
    {
        /// <summary>
        /// <value>Property <c>utaDemoApplyMoney</c></value>
        /// <para>
        /// Applied coin, supports BTC, ETH, USDT, USDC
        /// </para>
        /// </summary>
        public UtaDemoApplyMoneyItem[] utaDemoApplyMoney { get; set; } = default!;
    }

    public class UtaDemoApplyMoneyItem
    {
        /// <summary>
        /// <value>Property <c>coin</c></value>
        /// <para>
        /// Applied coin
        /// </para>
        /// </summary>
        public string coin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>amountStr</c></value>
        /// <remarks>
        /// Applied amount, the max applied amount in each request
        /// </remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Coin</term>
        /// <description>Max Applied Amount</description>
        /// </listheader>
        /// </list>
        /// <list type="bullet">
        /// <item>
        /// <term>BTC</term>
        /// <description>"15"</description>
        /// </item>
        /// <item>
        /// <term>ETH</term>
        /// <description>"200"</description>
        /// </item>
        /// <item>
        /// <term>USDT</term>
        /// <description>"100000"</description>
        /// </item>
        /// <item>
        /// <term>USDC</term>
        /// <description>"100000"</description>
        /// </item>
        /// </list>
        /// </summary>
        public string amountStr { get; set; } = default!;
    }


    public class DemoApplyMoneyResponse
    {

    }
}