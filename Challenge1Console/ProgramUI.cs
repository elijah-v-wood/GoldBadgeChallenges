using Challenge1Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge1Console
{
    public class ProgramUI
    {
        bool runFlag = true;
        MenuRepository _menu = new MenuRepository();

        public void Run()
        {
            Console.WriteLine("Seeding Menu Items...");
            Thread.Sleep(2000);
            Seed();
            MainMenu();
        }
        private void MainMenu()
        {
            while (runFlag)
            {
                Console.Clear();

                Console.WriteLine("Welcome!\n Please Select from a list of options below:\n"
                    + "1. Add New Menu Item\n"
                    + "2. Get Menu Items\n"
                    + "3. Delete or Remove an Item from the menu\n"
                    + "4. Exit the Program\n");

                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case string a when a.Contains("1"):
                    case string b when b.Contains("add"):
                    case string c when c.Contains("new"):
                        AddItem();
                        break;
                    case string d when d.Contains("2"):
                    case string e when e.Contains("get"):
                        PrintMenu();
                        break;
                    case string f when f.Contains("3"):
                    case string g when g.Contains("delete"):
                    case string h when h.Contains("remove"):
                        DeleteMenuItem();
                        break;
                    case string i when i.Contains("4"):
                    case string j when j.Contains("exit"):
                    case string k when k.Contains("leave"):
                        Console.WriteLine("Exiting the program.");
                        Thread.Sleep(1000);
                        Exit();
                        break;
                }

            }

        }
        private void AddItem()
        {
            Console.Clear();
            Console.WriteLine("Add New Item Menu:\n");


            Console.Write("Menu Number: ");
            string userInput = Console.ReadLine();
            var mealID = int.Parse(userInput);

            Console.Write("Item Name: ");
            userInput = Console.ReadLine();
            string mealName = userInput;

            Console.WriteLine("Description: ");
            userInput = Console.ReadLine();
            string mealDesc = userInput;

            Console.WriteLine("Ingredients: (Please ensure to use a comma between all ingredients");
            userInput = Console.ReadLine();
            string mealIng = userInput;

            Console.Write("Price: ");
            userInput = Console.ReadLine();
            var mealPrice = decimal.Parse(userInput);


            MenuItem meal = new MenuItem(mealID, mealName, mealDesc, mealIng, mealPrice);
            bool wasSuccessful = _menu.AddItemtoMenu(meal);
            Console.WriteLine((wasSuccessful) ? "\nItem was successfully added." : "\nFailed to add Item.");

            Continue();
        }
        private void PrintMenu()
        {
            Console.Clear();
            List<MenuItem> Menu = _menu.GetMenuItems();
            
            foreach(MenuItem item in Menu)
            {
                Display(item);
            }
            Continue();
        }
        private void DeleteMenuItem()
        {
            Console.Clear();
            Console.WriteLine("Please enter the menu number of the item you would like to delete:");
            
            string userInput = Console.ReadLine();
            int id = int.Parse(userInput);

            MenuItem menuItem = _menu.GetItembyNumber(id);
            Console.WriteLine($"{menuItem.Name}\nIs this Correct?(y/n)");
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case string x when x.Contains("y"):
                    string formerName = menuItem.Name;
                    _menu.DeleteMenuItem(menuItem);
                    Console.WriteLine($"{formerName} was deleted.");
                    break;
                default:
                    Console.WriteLine($"{menuItem.Name} was not deleted.");
                    break;
            }
            Continue();
        }
        public void Display(MenuItem item)
        {
            Console.WriteLine($"{item.Name}|| item no. {item.MealNumber}\n"
                +$"{item.Description}\n ${item.Price}\n");
        }
        private void Exit()
        {
            Console.Clear();

            Console.WriteLine("Have a nice day!");
            Thread.Sleep(2000);

            runFlag = false;
        }
        private void Continue()
        {
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
        private void Seed()
        {
            MenuItem m1 = new MenuItem(1,"Chicken Pesto Melt", "Grilled Chicken Breast and pesto with provolone. Stuck between to pieces of flatbread.","Chicken Breast, Pesto, Provolone, flatbread", 12.50m);
            MenuItem m2 = new MenuItem(2, "Tomato Bisque", "Thin Tomato Soup with select herbs and spices for flavor.", "Tomato base, Basil, Oregano", 8.50m);
            MenuItem m3 = new MenuItem(3, "House Salad w/ Chicken", "Sliced grilled Chicken Breast on Romaine Lettuce. Served with the house Onion Ranch", "Romaine Lettuce, Chicken Breast, Mild Cheedar, Carrot, Onion Ranch, Croutons", 7.20m);

            _menu.AddItemtoMenu(m1);
            _menu.AddItemtoMenu(m2);
            _menu.AddItemtoMenu(m3);

        }
    }
}
