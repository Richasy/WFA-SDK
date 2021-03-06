﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{
    public class EarthStatus
    {
        public string id { get; set; }
        public DateTime expiry { get; set; }
        public DateTime activation { get; set; }
        public bool isDay { get; set; }
        public string state { get; set; }
        public string timeLeft { get; set; }

        public override bool Equals(object obj)
        {
            return obj is EarthStatus status &&
                   id == status.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + EqualityComparer<string>.Default.GetHashCode(id);
        }
    }
}
