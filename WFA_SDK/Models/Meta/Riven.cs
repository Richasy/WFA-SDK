using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.Meta
{
    public class Riven
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string thumb { get; set; }
        public string type { get; set; }
        /// <summary>
        /// 倾向性星级
        /// </summary>
        public int rank { get; set; }
        /// <summary>
        /// 倾向性系数
        /// </summary>
        public double modulus { get; set; }
        public Riven()
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Riven riven &&
                   name.Equals(riven.name,StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return 363513814 + EqualityComparer<string>.Default.GetHashCode(name);
        }
    }
}
