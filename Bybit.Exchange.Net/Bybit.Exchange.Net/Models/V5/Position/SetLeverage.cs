using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Position
{
    public class SetLeverageRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <remarks>
        /// Product type
        /// </remarks>
        /// </summary>
        public Category? category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>buyLeverage</c></value>
        /// <para>
        /// [1, max leverage of corresponding risk limit]
        /// </para>
        /// <para>
        /// One-way mode: buyLeverage must be the same as sellLeverage
        /// </para>
        /// <para>
        /// Hedge mode:
        /// Classic account &amp; UTA (isolated margin): buyLeverage and sellLeverage can be different;
        /// UTA (cross margin): buyLeverage must be the same as sellLeverage
        /// </para>
        /// </summary>
        public string buyLeverage { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>sellLeverage</c></value>
        /// <para>
        /// [1, max leverage of corresponding risk limit]
        /// </para>
        /// </summary>
        public string sellLeverage { get; set; } = default!;
    }

    public class SetLeverageResponse
    {
    }
}
