using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.WarframeMarket
{
    public class Statistics
    {
        public List<Unit> _48hours { get; set; }
        public List<Unit> _90days { get; set; }
    }

    public class Unit
    {
        public DateTime datetime { get; set; }
        public double volume { get; set; }
        public double min_price { get; set; }
        public double max_price { get; set; }
        public double open_price { get; set; }
        public double closed_price { get; set; }
        public double avg_price { get; set; }
        public double wa_price { get; set; }
        public double median { get; set; }
        public double donch_top { get; set; }
        public double donch_bot { get; set; }
        public string id { get; set; }
        public double moving_avg { get; set; }
        public string order_type { get; set; }
    }
}
