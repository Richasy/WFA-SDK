using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.Lib
{
    public class Patchlog
    {
        public int Id { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public string url { get; set; }
        public string imgUrl { get; set; }
        public string additions { get; set; }
        public string changes { get; set; }
        public string fixes { get; set; }
    }
}
