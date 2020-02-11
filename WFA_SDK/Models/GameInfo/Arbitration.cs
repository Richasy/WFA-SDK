using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{
    public class Arbitration
    {
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }
        public string solnode { get; set; }
        public string node { get; set; }
        public string name { get; set; }
        public string tile { get; set; }
        public string planet { get; set; }
        public string enemy { get; set; }
        public string type { get; set; }
        public string node_type { get; set; }
        public bool archwing { get; set; }
        public bool sharkwing { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Arbitration arbitration &&
                   solnode == arbitration.solnode &&
                   type == arbitration.type;
        }

        public override int GetHashCode()
        {
            var hashCode = -1789824066;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(solnode);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(type);
            return hashCode;
        }
    }

}
