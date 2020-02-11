using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{
    public class VallisStatus
    {
        public string id { get; set; }
        public DateTime expiry { get; set; }
        public bool isWarm { get; set; }
        public string state { get; set; }
        public DateTime activation { get; set; }
        public string timeLeft { get; set; }
        public string shortString { get; set; }

        public override bool Equals(object obj)
        {
            return obj is VallisStatus status &&
                   id == status.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + EqualityComparer<string>.Default.GetHashCode(id);
        }
        public override string ToString()
        {
            string prefix = "Now Orb Vallis is: ";
            string status = isWarm ? "Warm" : "Cold";
            return prefix + status;
        }
    }
}
