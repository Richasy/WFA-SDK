using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.Meta
{
    public class Meta
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string value { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Meta meta &&
                   name == meta.name;
        }

        public override int GetHashCode()
        {
            return 363513814 + EqualityComparer<string>.Default.GetHashCode(name);
        }
    }
}
