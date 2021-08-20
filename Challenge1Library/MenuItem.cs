using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1Library
{
    public class MenuItem
    {
        public int MealNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }

        public MenuItem() { }
        public MenuItem(int mealNum, string name, string description, string ingredients, decimal price)
        {
            MealNumber = mealNum;
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }
    }
}
