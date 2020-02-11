using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{
    public class VoidTrader
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }
        public string character { get; set; }
        public string location { get; set; }
        public List<Inventory> inventory { get; set; }
        public string psId { get; set; }
        public bool active { get; set; }
        public string startString { get; set; }
        public string endString { get; set; }

        public override bool Equals(object obj)
        {
            return obj is VoidTrader trader &&
                   id == trader.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + EqualityComparer<string>.Default.GetHashCode(id);
        }
    }
    public class Inventory
    {
        public string item { get; set; }
        public int ducats { get; set; }
        public int credits { get; set; }
        public Inventory()
        {

        }
    }
}
