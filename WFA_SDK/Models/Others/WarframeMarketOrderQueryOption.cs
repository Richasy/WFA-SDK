using System;
using System.Collections.Generic;
using System.Text;
using WarframeAlertingPrime.SDK.Models.Enums;

namespace WarframeAlertingPrime.SDK.Models.Others
{
    public class WarframeMarketOrderQueryOption
    {
        /// <summary>
        /// Item name
        /// </summary>
        public string Code { get; set; }
        public int PageSize { get; set; }
        public int Page { get; set; }
        /// <summary>
        /// Order tyep. <c>sell</c> or <c>buy</c>
        /// </summary>
        public OrderType Type { get; set; }
        public int ModRank { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public List<WMOrderStatus> OrderStatus { get; set; }
        public WarframeMarketOrderQueryOption()
        {
            Page = 1;
            PageSize = 10;
            Type = OrderType.Sell;
            MinPrice = 0;
            MaxPrice = 0;
            OrderStatus = new List<WMOrderStatus> { WMOrderStatus.InGame };
        }
    }
}
