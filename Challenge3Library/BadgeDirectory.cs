using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3Library
{
    public class BadgeDirectory
    {
        public List<Badge> Badges = new List<Badge>();

        public Dictionary<int, Badge> _badgeDictionary = new Dictionary<int, Badge>();
        Badge b1 = new Badge(12345, "A5 B7");

        public bool AddToDictionary(Badge badge)
        {
            int startingCount = _badgeDictionary.Count;
            _badgeDictionary.Add(badge.BadgeID, badge);

            bool wasAdded = _badgeDictionary.Count > startingCount;
            return wasAdded;
        }
        public bool RemoveFromDictionary(Badge badge)
        {
            int startingCount = _badgeDictionary.Count;
            _badgeDictionary.Remove(badge.BadgeID);

            bool wasRemoved = _badgeDictionary.Count < startingCount;
            return wasRemoved;

        }
        public void PrintDictionary()
        {
            Console.WriteLine($"{ "Badge Number",-10} {"Door Access",20}");
            foreach(KeyValuePair<int,Badge> kvp in _badgeDictionary)
            {
                Console.WriteLine($"{kvp.Key,-10} {_badgeDictionary[kvp.Key].DoorAccess,20}");
            }
        }

    }
}
