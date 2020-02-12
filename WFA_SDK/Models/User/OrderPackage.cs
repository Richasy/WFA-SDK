using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.User
{
    public class OrderPackage
    {
        public List<Order> Items { get; set; }
        public int count { get; set; }
        public int page { get; set; }
        public bool hasMore { get; set; }
    }
    public class Profile
    {
        public Account profile { get; set; }
        public List<Order> orders { get; set; }
    }
}
