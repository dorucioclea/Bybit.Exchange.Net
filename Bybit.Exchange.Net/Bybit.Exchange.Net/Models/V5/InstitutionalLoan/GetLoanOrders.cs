namespace Bybit.Exchange.Net.Models.V5.InstitutionalLoan
{
    public class GetLoanOrdersRequest
    {
        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <para>
        /// Loan order id. If not passed, then return all orders, sorted by loanTime in descending order.
        /// </para>
        /// </summary>
        public string? orderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>startTime</c></value>
        /// <para>
        /// The start timestamp (ms)
        /// </para>
        /// </summary>
        public long? startTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>endTime</c></value>
        /// <para>
        /// The end timestamp (ms)
        /// </para>
        /// </summary>
        public long? endTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>limit</c></value>
        /// <para>
        /// Limit for data size. [1, 100], Default: 10
        /// </para>
        /// </summary>
        public int? limit { get; set; } = default!;
    }


    public class GetLoanOrdersResponse
    {
        /// <summary>
        /// <value>Property <c>loanInfo</c></value>
        /// <para>
        /// Array of loan information.
        /// </para>
        /// </summary>
        public LoanInfoItem[] LoanInfo { get; set; } = default!;

        public class LoanInfoItem
        {
            /// <summary>
            /// <value>Property <c>orderId</c></value>
            /// <para>
            /// Loan order ID
            /// </para>
            /// </summary>
            public string OrderId { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>orderProductId</c></value>
            /// <para>
            /// Product ID
            /// </para>
            /// </summary>
            public string OrderProductId { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>parentUid</c></value>
            /// <para>
            /// The designated UID that used to bind INS loan product
            /// </para>
            /// </summary>
            public string ParentUid { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>loanTime</c></value>
            /// <para>
            /// Loan timestamp, in milliseconds
            /// </para>
            /// </summary>
            public string LoanTime { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>loanCoin</c></value>
            /// <para>
            /// Loan coin
            /// </para>
            /// </summary>
            public string LoanCoin { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>loanAmount</c></value>
            /// <para>
            /// Loan amount
            /// </para>
            /// </summary>
            public string LoanAmount { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>unpaidAmount</c></value>
            /// <para>
            /// Unpaid principal
            /// </para>
            /// </summary>
            public string UnpaidAmount { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>unpaidInterest</c></value>
            /// <para>
            /// Unpaid interest
            /// </para>
            /// </summary>
            public string UnpaidInterest { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>repaidAmount</c></value>
            /// <para>
            /// Repaid principal
            /// </para>
            /// </summary>
            public string RepaidAmount { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>repaidInterest</c></value>
            /// <para>
            /// Repaid interest
            /// </para>
            /// </summary>
            public string RepaidInterest { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>interestRate</c></value>
            /// <para>
            /// Daily interest rate
            /// </para>
            /// </summary>
            public string InterestRate { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>status</c></value>
            /// <para>
            /// 1: outstanding; 2: paid off
            /// </para>
            /// </summary>
            public string Status { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>leverage</c></value>
            /// <para>
            /// The maximum leverage for this loan product
            /// </para>
            /// </summary>
            public string Leverage { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>supportSpot</c></value>
            /// <para>
            /// Whether to support spot. 0: false; 1: true
            /// </para>
            /// </summary>
            public string SupportSpot { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>supportContract</c></value>
            /// <para>
            /// Whether to support contract. 0: false; 1: true
            /// </para>
            /// </summary>
            public string SupportContract { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>withdrawLine</c></value>
            /// <para>
            /// Restrict line for withdrawal
            /// </para>
            /// </summary>
            public string WithdrawLine { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>transferLine</c></value>
            /// <para>
            /// Restrict line for transfer
            /// </para>
            /// </summary>
            public string TransferLine { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>spotBuyLine</c></value>
            /// <para>
            /// Restrict line for SPOT buy
            /// </para>
            /// </summary>
            public string SpotBuyLine { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>spotSellLine</c></value>
            /// <para>
            /// Restrict line for SPOT sell
            /// </para>
            /// </summary>
            public string SpotSellLine { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>contractOpenLine</c></value>
            /// <para>
            /// Restrict line for USDT Perpetual open position
            /// </para>
            /// </summary>
            public string ContractOpenLine { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>deferredLiquidationLine</c></value>
            /// <para>
            /// Line for deferred liquidation
            /// </para>
            /// </summary>
            public string DeferredLiquidationLine { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>deferredLiquidationTime</c></value>
            /// <para>
            /// Time for deferred liquidation
            /// </para>
            /// </summary>
            public string DeferredLiquidationTime { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>liquidationLine</c></value>
            /// <para>
            /// Line for liquidation
            /// </para>
            /// </summary>
            public string LiquidationLine { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>stopLiquidationLine</c></value>
            /// <para>
            /// Line for stop liquidation
            /// </para>
            /// </summary>
            public string StopLiquidationLine { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>contractLeverage</c></value>
            /// <para>
            /// The allowed default leverage for USDT Perpetual
            /// </para>
            /// </summary>
            public string ContractLeverage { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>transferRatio</c></value>
            /// <para>
            /// The transfer ratio for loan funds to transfer from Spot wallet to Contract wallet
            /// </para>
            /// </summary>
            public string TransferRatio { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>spotSymbols</c></value>
            /// <para>
            /// The whitelist of spot trading pairs. If there is no whitelist, then "[]"
            /// </para>
            /// </summary>
            public string[] SpotSymbols { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>contractSymbols</c></value>
            /// <para>
            /// The whitelist of contract trading pairs. If supportContract="0", then this is "[]". If there is no whitelist, this is "[]".
            /// </para>
            /// </summary>
            public string[] ContractSymbols { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>supportUSDCContract</c></value>
            /// <para>
            /// Whether to support USDC contract. "0":false; "1":true
            /// </para>
            /// </summary>
            public string SupportUSDCContract { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>supportUSDCOptions</c></value>
            /// <para>
            /// Whether to support Option. "0":false; "1":true
            /// </para>
            /// </summary>
            public string SupportUSDCOptions { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>supportMarginTrading</c></value>
            /// <para>
            /// Whether to support Spot margin trading. "0":false; "1":true
            /// </para>
            /// </summary>
            public string SupportMarginTrading { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>USDTPerpetualOpenLine</c></value>
            /// <para>
            /// Restrict line to open USDT Perpetual position
            /// </para>
            /// </summary>
            public string USDTPerpetualOpenLine { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>USDCContractOpenLine</c></value>
            /// <para>
            /// Restrict line to open USDC Contract position
            /// </para>
            /// </summary>
            public string USDCContractOpenLine { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>USDCOptionsOpenLine</c></value>
            /// <para>
            /// Restrict line to open Option position
            /// </para>
            /// </summary>
            public string USDCOptionsOpenLine { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>USDTPerpetualCloseLine</c></value>
            /// <para>
            /// Restrict line to trade USDT Perpetual position
            /// </para>
            /// </summary>
            public string USDTPerpetualCloseLine { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>USDCContractCloseLine</c></value>
            /// <para>
            /// Restrict line to trade USDC Contract position
            /// </para>
            /// </summary>
            public string USDCContractCloseLine { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>USDCOptionsCloseLine</c></value>
            /// <para>
            /// Restrict line to trade Option position
            /// </para>
            /// </summary>
            public string USDCOptionsCloseLine { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>USDCContractSymbols</c></value>
            /// <para>
            /// The whitelist of USDC contract trading pairs. If no whitelist symbols, it is [], and you can trade any. If supportUSDCContract="0", it is [].
            /// </para>
            /// </summary>
            public string[] USDCContractSymbols { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>USDCOptionsSymbols</c></value>
            /// <para>
            /// The whitelist of Option symbols. If no whitelisted, it is [], and you can trade any. If supportUSDCOptions="0", it is [].
            /// </para>
            /// </summary>
            public string[] USDCOptionsSymbols { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>marginLeverage</c></value>
            /// <para>
            /// The allowable maximum leverage for Spot margin
            /// </para>
            /// </summary>
            public string MarginLeverage { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>USDTPerpetualLeverage</c></value>
            /// <para>
            /// Array of USDT Perpetual leverage information. If supportContract="0", it is []. If no whitelist USDT perp symbols, it returns all trading symbols and leverage by default. If there are whitelist symbols, it returns those whitelist data.
            /// </para>
            /// </summary>
            public USDTPerpetualLeverageItem[] USDTPerpetualLeverage { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>USDCContractLeverage</c></value>
            /// <para>
            /// Array of USDC Contract leverage information. If supportUSDCContract="0", it is []. If no whitelist USDC contract symbols, it returns all trading symbols and leverage by default. If there are whitelist symbols, it returns those whitelist data.
            /// </para>
            /// </summary>
            public USDCContractLeverageItem[] USDCContractLeverage { get; set; } = default!;
        }

        public class USDTPerpetualLeverageItem
        {
            /// <summary>
            /// <value>Property <c>symbol</c></value>
            /// <para>
            /// Symbol name
            /// </para>
            /// </summary>
            public string Symbol { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>leverage</c></value>
            /// <para>
            /// Maximum leverage
            /// </para>
            /// </summary>
            public string Leverage { get; set; } = default!;
        }

        public class USDCContractLeverageItem
        {
            /// <summary>
            /// <value>Property <c>symbol</c></value>
            /// <para>
            /// Symbol name
            /// </para>
            /// </summary>
            public string Symbol { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>leverage</c></value>
            /// <para>
            /// Maximum leverage
            /// </para>
            /// </summary>
            public string Leverage { get; set; } = default!;
        }
    }
}
