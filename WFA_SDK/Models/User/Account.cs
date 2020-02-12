using System;
using System.Collections.Generic;
using System.Text;

namespace WarframeAlertingPrime.SDK.Models.User
{
    public class Account
    {
        public int Id { get; set; }
        public string userId { get; set; }
        public string displayName { get; set; }
        public string introduce { get; set; }
        public int level { get; set; }
        public int reputation { get; set; }
        public string mail { get; set; }
        public string gameName { get; set; }
        public int credit { get; set; }
        public int experience { get; set; }
        public List<Badge> badges { get; set; }
        public Badge showBadge { get; set; }
        public UserStatus status { get; set; }
        public int lastSignTime { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Account account &&
                   userId == account.userId;
        }

        public override int GetHashCode()
        {
            return -394678857 + EqualityComparer<string>.Default.GetHashCode(userId);
        }
    }
    public class SlimAccount
    {
        public string userId { get; set; }
        public string displayName { get; set; }
        public int level { get; set; }
        public Badge showBadge { get; set; }
        public UserStatus status { get; set; }
        public string gameName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is SlimAccount account &&
                   userId == account.userId;
        }

        public override int GetHashCode()
        {
            return -394678857 + EqualityComparer<string>.Default.GetHashCode(userId);
        }

        public override string ToString()
        {
            return displayName;
        }
        public SlimAccount()
        {

        }
        public SlimAccount(Account acc)
        {
            userId = acc.userId;
            displayName = acc.displayName;
            level = acc.level;
            showBadge = acc.showBadge;
            status = acc.status;
            gameName = acc.gameName;
        }
    }
    public class Badge
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Badge()
        {

        }
        public override bool Equals(object obj)
        {
            return obj is Badge badge &&
                   Name == badge.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
    }
    public enum UserStatus
    {
        InGame,
        Online,
        Offline,
        Suspend
    }
}
