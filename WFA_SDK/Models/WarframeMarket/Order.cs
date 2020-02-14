using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.WarframeMarket
{
    public class Order
    {
        public int quantity { get; set; }
        public DateTime? creation_date { get; set; }
        public bool visible { get; set; }
        public User user { get; set; }
        public DateTime? last_update { get; set; }
        public float platinum { get; set; }
        public string order_type { get; set; }
        public string region { get; set; }
        public string platform { get; set; }
        public string id { get; set; }
        public int? mod_rank { get; set; }
        public string item_name { get; set; }
        public Item item { get; set; }
    }
    public class RecentOrders
    {
        public List<Order> Sell { get; set; }
        public List<Order> Buy { get; set; }
    }
    public class OrderQueryResult
    {
        public List<Order> Items { get; set; }
        public bool HasMore { get; set; }
        public int Page { get; set; }
        public int ItemsCount { get; set; }
        public int TotalCount { get; set; }
    }
}
