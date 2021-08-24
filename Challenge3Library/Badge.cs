using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3Library
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public string DoorAccess { get; set; } 





        public Badge() { }
        public Badge(int id, string access)
        {
            BadgeID = id;
            DoorAccess = access;
        }
        
    }
}
