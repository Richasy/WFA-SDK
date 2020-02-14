using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.WarframeMarket
{
    public class Profile:User
    {
        public bool own_profile { get; set; }
        public DateTime last_seen { get; set; }
        public object background { get; set; }
        public string platform { get; set; }
        public bool banned { get; set; }
        public string about { get; set; }
    }
    public class ProfileWithOrders
    {
        public Profile Profile { get; set; }
        public List<Order> Sell { get; set; }
        public List<Order> Buy { get; set; }
    }
}
