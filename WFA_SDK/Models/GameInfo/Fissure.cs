using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{

    public class Fissure:INotifyPropertyChanged
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public string startString { get; set; }
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
        public bool active { get; set; }
        public string node { get; set; }
        public string missionType { get; set; }
        public string enemy { get; set; }
        public string tier { get; set; }
        public int tierNum { get; set; }
        public bool expired { get; set; }
        public string eta { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override bool Equals(object obj)
        {
            return obj is Fissure fissure &&
                   id == fissure.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + EqualityComparer<string>.Default.GetHashCode(id);
        }
    }

}
