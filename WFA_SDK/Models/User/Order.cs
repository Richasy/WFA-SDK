using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WarframeAlertingPrime.SDK.Models.Enums;

namespace WarframeAlertingPrime.SDK.Models.User
{
    public class Order
    {
        public string weapon { get; set; }
        public string successUser { get; set; }
        public string category { get; set; }
        private RMOrderStatus _status;
        public RMOrderStatus status
        {
            get => _status;
            set { _status = value; OnPropertyChanged(); }
        }
        public string orderId { get; set; }
        public int reset { get; set; }
        public int dan { get; set; }
        public string polarity { get; set; }
        public string platform { get; set; }
        public int createTime { get; set; }
        public bool isVeiled { get; set; }
        public OrderType orderType { get; set; }
        public int platinum { get; set; }
        public int modRank { get; set; }
        public string description { get; set; }
        public List<Property> properties { get; set; }
        public List<SlimAccount> locking { get; set; }
        public SlimAccount account { get; set; }

        public event EventHandler<string> PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string name="")
        {
            PropertyChanged?.Invoke(this, name);
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   orderId == order.orderId;
        }

        public override int GetHashCode()
        {
            return 1620140362 + EqualityComparer<string>.Default.GetHashCode(orderId);
        }
        public event EventHandler<bool> Refresh;
        public void Copy(Order item)
        {
            successUser = item.successUser;
            status = item.status;
            reset = item.reset;
            dan = item.dan;
            polarity = item.polarity;
            platinum = item.platinum;
            modRank = item.modRank;
            description = item.description;
            properties = item.properties;
            locking = item.locking;
            account = item.account;
            Refresh?.Invoke(this, true);
        }
    }
    
    public class LockUser
    {
        public int Id { get; set; }
        public string userId { get; set; }
        public int lockTime { get; set; }
        public LockUser()
        {

        }

        public override bool Equals(object obj)
        {
            return obj is LockUser user &&
                   userId == user.userId;
        }

        public override int GetHashCode()
        {
            return -394678857 + EqualityComparer<string>.Default.GetHashCode(userId);
        }
    }
    public class Property:INotifyPropertyChanged
    {
        public string name { get; set; }
        private bool _isDeduction;
        public bool isDeduction
        {
            get => _isDeduction;
            set
            {
                _isDeduction = value;
                OnPropertyChanged();
            }
        }
        public DisplayType displayType { get; set; }
        public double value { get; set; }
        public Property()
        {
            isDeduction = false;
        }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(name) || value <= 0)
                return false;
            else
                return true;
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public override bool Equals(object obj)
        {
            return obj is Property property &&
                   name == property.name &&
                   isDeduction == property.isDeduction &&
                   value == property.value;
        }

        public override int GetHashCode()
        {
            var hashCode = 856639788;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + isDeduction.GetHashCode();
            hashCode = hashCode * -1521134295 + value.GetHashCode();
            return hashCode;
        }
    }
}
