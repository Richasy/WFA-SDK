using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{
    public class ConstructionProgress
    {
        public string id { get; set; }
        public string fomorianProgress { get; set; }
        public string razorbackProgress { get; set; }
        public string unknownProgress { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ConstructionProgress progress &&
                   id == progress.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + EqualityComparer<string>.Default.GetHashCode(id);
        }
    }
}
