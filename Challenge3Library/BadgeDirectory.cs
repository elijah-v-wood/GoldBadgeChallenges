using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3Library
{
    public class BadgeDirectory
    {
        Badge B1 = new Badge(12345, "A1,A2,A3,B4,B6");
        Badge B2 = new Badge(12346, "A1,A2,A3,B3,B6");
        Badge B3 = new Badge(12347, "A1,A2,B3,C4");
        
        
        
        Dictionary<int, Badge> Badges = new Dictionary<int, Badge>();


    }
}
