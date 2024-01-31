﻿namespace Bybit.Exchange.Net.Models.V5.C2CLending
{
    public class DepositFundsRequest
    {
        /// <summary>
        /// <value>Property <c>coin</c></value>
        /// <para>
        /// Coin name
        /// </para>
        /// </summary>
        public string coin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>quantity</c></value>
        /// <para>
        /// Deposit quantity
        /// </para>
        /// </summary>
        public string quantity { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>serialNo</c></value>
        /// <para>
        /// Customised ID. If not passed, system will create one by default
        /// </para>
        /// </summary>
        public string serialNo { get; set; } = default!;
    }

    public class DepositFundsResponse
    {
        /// <summary>
        /// <value>Property <c>coin</c></value>
        /// <para>
        /// Coin name
        /// </para>
        /// </summary>
        public string Coin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>createdTime</c></value>
        /// <para>
        /// Created timestamp (ms)
        /// </para>
        /// </summary>
        public string CreatedTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <para>
        /// Order ID
        /// </para>
        /// </summary>
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>quantity</c></value>
        /// <para>
        /// Deposit quantity
        /// </para>
        /// </summary>
        public string Quantity { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>serialNo</c></value>
        /// <para>
        /// Serial No
        /// </para>
        /// </summary>
        public string SerialNo { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>status</c></value>
        /// <para>
        /// Order status. 0: Initial, 1: Processing, 2: Success, 10: Failed
        /// </para>
        /// </summary>
        public string Status { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>updatedTime</c></value>
        /// <para>
        /// Updated timestamp (ms)
        /// </para>
        /// </summary>
        public string UpdatedTime { get; set; } = default!;
    }
}