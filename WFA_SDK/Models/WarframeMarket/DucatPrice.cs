using System;
using System.Collections.Generic;
using System.Text;

namespace WarframeAlertingPrime.SDK.Models.WarframeMarket
{
    public class DucatPricePayload
    {
        public List<DucatPriceItem> previous_hour { get; set; }
        public List<DucatPriceItem> previous_day { get; set; }
    }

    public class DucatPriceItem
    {
        public DateTime datetime { get; set; }
        public int position_change_month { get; set; }
        public int position_change_week { get; set; }
        public int position_change_day { get; set; }
        public double plat_worth { get; set; }
        public int volume { get; set; }
        public double ducats_per_platinum { get; set; }
        public double ducats_per_platinum_wa { get; set; }
        public int ducats { get; set; }
        public string item { get; set; }
        public double median { get; set; }
        public double wa_price { get; set; }
        public string id { get; set; }
    }
}
