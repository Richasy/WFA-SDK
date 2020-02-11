using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{

    public class AlertReward
    {
        public IList<string> items { get; set; }
        public IList<Counteditem> countedItems { get; set; }
        public int credits { get; set; }
        public string asString { get; set; }
        public string itemString { get; set; }
        public string thumbnail { get; set; }
        public int color { get; set; }
    }

    public class AlertMission
    {
        public string node { get; set; }
        public string type { get; set; }
        public string faction { get; set; }
        public AlertReward reward { get; set; }
        public int minEnemyLevel { get; set; }
        public int maxEnemyLevel { get; set; }
        public int maxWaveNum { get; set; }
        public bool nightmare { get; set; }
        public bool archwingRequired { get; set; }
    }

    public class Alert: INotifyPropertyChanged
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        private DateTime _expiry;
        public DateTime expiry
        {
            get => _expiry;
            set
            {
                _expiry = value;
                OnPropertyChanged();
            }
        }
        public AlertMission mission { get; set; }
        public bool expired { get; set; }
        public string eta { get; set; }
        public IList<string> rewardTypes { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override bool Equals(object obj)
        {
            return obj is Alert alert &&
                   id == alert.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + EqualityComparer<string>.Default.GetHashCode(id);
        }
    }
}
