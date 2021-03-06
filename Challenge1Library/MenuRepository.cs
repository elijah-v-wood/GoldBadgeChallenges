using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1Library
{
    public class MenuRepository
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
        public MenuItem GetItembyNumber(int id)
        {
            foreach(MenuItem item in _menuItems)
            {
                if (item.MealNumber == id)
                {
                    return item;
                }
            }
            return null;
        }
        public List<MenuItem> GetItemsById(int id)
        {
            List<MenuItem> IdMenu = new List<MenuItem>();
            foreach(MenuItem item in _menuItems)
            {
                if(item.MealNumber== id)
                {
                    IdMenu.Add(item);
                }
            }
            return IdMenu;
        }
    }
}
