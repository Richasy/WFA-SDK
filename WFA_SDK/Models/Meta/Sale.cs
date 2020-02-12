using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.Meta
{
    public class Sale
    {
        public int Id { get; set; }
        public string code { get; set; }
        public string main { get; set; }
        public string component { get; set; }
        public string zh { get; set; }
        public string en { get; set; }
        public string thumb { get; set; }
        public override bool Equals(object obj)
        {
            return obj is Sale sale &&
                   code == sale.code;
        }
        public override int GetHashCode()
        {
            return -1021610220 + EqualityComparer<string>.Default.GetHashCode(code);
        }

    }
}
