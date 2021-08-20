using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1Library
{
    class MenuRepository
    {
        public List<MenuItem> _menuItems = new List<MenuItem>();


        public bool AddItemtoMenu(MenuItem item)
        {
            int startingCount = _menuItems.Count;
            _menuItems.Add(item);
            bool wasAdded = _menuItems.Count > startingCount;
            return wasAdded;
        }
        public List<MenuItem> GetMenuItems()
        {
            return _menuItems;
        }
        public bool DeleteMenuItem(MenuItem item)
        {
            bool deleteResult = _menuItems.Remove(item);
            return deleteResult;
        }
    }
}
