using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.Meta
{
    public class Dict
    {
        public int Id { get; set; }
        public string zh { get; set; }
        public string en { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Dict dict &&
                   en == dict.en;
        }

        public override int GetHashCode()
        {
            return -641526502 + EqualityComparer<string>.Default.GetHashCode(en);
        }
    }
}
