using System;
using System.Collections.Generic;
using System.Text;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{
    public class CambionStatus
    {
        public string active { get; set; }
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }

        public override bool Equals(object obj)
        {
            return obj is CambionStatus status &&
                   active == status.active &&
                   activation == status.activation;
        }

        public override int GetHashCode()
        {
            int hashCode = 302637988;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(active);
            hashCode = hashCode * -1521134295 + activation.GetHashCode();
            return hashCode;
        }
    }
}
