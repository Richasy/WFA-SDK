using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{

    public class Kuva : INotifyPropertyChanged
    {
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
        public string solnode { get; set; }
        public string node { get; set; }
        public string name { get; set; }
        public string tile { get; set; }
        public string planet { get; set; }
        public string enemy { get; set; }
        public string type { get; set; }
        public string node_type { get; set; }
        public bool archwing { get; set; }
        public bool sharkwing { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override bool Equals(object obj)
        {
            return obj is Kuva kuva &&
                   solnode == kuva.solnode &&
                   type == kuva.type && expiry==kuva.expiry;
        }

        public override int GetHashCode()
        {
            var hashCode = -1789824066;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(solnode);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(type);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime>.Default.GetHashCode(expiry);
            return hashCode;
        }
    }

}
