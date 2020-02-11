using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{

    public class Darvo
    {
        public string item { get; set; }
        public DateTime expiry { get; set; }
        public DateTime activation { get; set; }
        public int originalPrice { get; set; }
        public int salePrice { get; set; }
        public int total { get; set; }
        public int sold { get; set; }
        public string id { get; set; }
        public string eta { get; set; }
        public int discount { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Darvo darvo &&
                   id == darvo.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + EqualityComparer<string>.Default.GetHashCode(id);
        }
    }

}
