using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Market
{
    public class GetFundingRateHistoryRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <remarks>
        /// Product type:
        /// spot, linear, inverse, option
        /// </remarks>
        /// </summary>
        public required Category category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string? symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>StartTime</c></value>
        /// <para>
        /// Start Time
        /// </para>
        /// </summary>
        public int? StartTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>EndTime</c></value>
        /// <para>
        /// End Time
        /// </para>
        /// </summary>
        public int? EndTime { get; set; } = default!;


        /// <summary>
        /// <value>Property <c>limit</c></value>
        /// <para>
        /// Limit size for each bid and ask
        /// </para>
        /// </summary>
        public int? limit { get; set; } = default!;
    }

    public class GetFundingRateHistoryResponse
    {
        /// <summary>
        /// <value>Property <c>Category</c></value>
        /// <para>
        /// Product type
        /// </para>
        /// </summary>
        public string? Category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>list</c></value>
        /// <para>
        /// Object
        /// </para>
        /// </summary>
        public List<GetFundingRateHistoryItem>? List { get; set; } = default!;
    }

    /// <summary>
    /// ListItem class for Get Funding Rate History Item
    /// </summary>
    public class GetFundingRateHistoryItem
    {
        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string? Symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>FundingRate</c></value>
        /// <para>
        /// Funding rate
        /// </para>
        /// </summary>
        public string? FundingRate { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>FundingRateTimestamp</c></value>
        /// <para>
        /// Funding rate timestamp (ms)
        /// </para>
        /// </summary>
        public string? FundingRateTimestamp { get; set; } = default!;
    }
}