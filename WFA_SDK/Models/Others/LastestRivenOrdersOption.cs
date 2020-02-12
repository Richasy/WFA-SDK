using System;
using System.Collections.Generic;
using System.Text;

namespace WarframeAlertingPrime.SDK.Models.Others
{
    public class LastestRivenOrdersOption
    {
        /// <summary>
        /// Order type. The default is <c>sell</c>
        /// </summary>
        public string OrderType { get; set; }
        /// <summary>
        /// Number of entries per page. The default is <c>10</c>
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// Page number, the start is 1. The default is <c>1</c>
        /// </summary>
        public int Page { get; set; }
        public LastestRivenOrdersOption()
        {
            OrderType = "sell";
            PageSize = 10;
            Page = 1;
        }
    }
}
