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
        MenuRepository Menu = new MenuRepository();

        public void Run()
        {
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
                    + "3. Remove an Item from the menu\n"
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
                        Console.WriteLine("DEBUG((REMOVE LATER)) selection 2");
                        break;
                    case string f when f.Contains("3"):
                    case string g when g.Contains("delete"):
                    case string h when h.Contains("remove"):
                        Console.WriteLine("DEBUG((REMOVE LATER)) selection 3");
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

            Console.Write("Description: ");
            userInput = Console.ReadLine();
            string mealDesc = userInput;

            Console.Write("Ingredients: ");
            userInput = Console.ReadLine();
            string mealIng = userInput;

            Console.Write("Price: ");
            userInput = Console.ReadLine();
            var mealPrice = decimal.Parse(userInput);


            MenuItem meal = new MenuItem(mealID, mealName, mealDesc, mealIng, mealPrice);
            bool wasSuccessful = Menu.AddItemtoMenu(meal);
            Console.WriteLine((wasSuccessful) ? "\nItem was successfully added." : "\nFailed to add Item.");

            Continue();
        }
        private void PrintMenu()
        {

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

        }
    }
}
