using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.WarframeMarket
{
    public class User
    {
        public string ingame_name { get; set; }
        public int reputation_bonus { get; set; }
        public int reputation { get; set; }
        public string region { get; set; }
        public string avatar { get; set; }
        public string status { get; set; }
        public string id { get; set; }
    }
}
