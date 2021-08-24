using Challenge3Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge3Console
{
    public class ProgramUI
    {
        BadgeDirectory BadgeDirectory = new BadgeDirectory();
        bool Running = true;



        public void Run()
        {
            Seed();
            Menu();

        }

        private void Seed()
        {
            Badge b1 = new Badge(12446, "A7 B4");
            Badge b2 = new Badge(12456, "A7 B4 C2");
            Badge b3 = new Badge(13456, "A7 B4 C3");

            BadgeDirectory.AddToDictionary(b1);
            BadgeDirectory.AddToDictionary(b2);
            BadgeDirectory.AddToDictionary(b3);
        }


        private void Menu()
        {
            while (Running)
            {

                Console.Clear();

                Console.WriteLine("Hello Security Admin!");

                Console.WriteLine("Please select from the following:\n" +
                    "1. Add a badge\n" +
                    "2. Edit a Badge\n" +
                    "3. List all Badges\n" +
                    "4. Exit the program");

                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case string a when a.Contains("1"):
                    case string b when b.Contains("add"):
                        AddBadge();
                        break;
                    case string d when d.Contains("2"):
                    case string e when e.Contains("edit"):

                        break;
                    case string f when f.Contains("3"):
                    case string g when g.Contains("list"):
                        BadgeDirectory.PrintDictionary();
                        Continue();
                        break;
                    case string i when i.Contains("4"):
                    case string j when j.Contains("exit"):
                        ExitProgram();
                        break;
                    default:
                        InvalidSelection();
                        break;







                }
            }
        }
        private void AddBadge()
        {
            Console.Clear();

            Console.WriteLine("Please Enter the following:");
            
            Console.Write("Badge Number: ");
            int badgeID = int.Parse(Console.ReadLine());
            
            Console.Write("Door Access: ");
            string doorAccess = Console.ReadLine().ToUpper();

            Badge newBadge = new Badge(badgeID, doorAccess);

            bool useTheDoorsLuke = true;
            while (useTheDoorsLuke)
            {
                Console.WriteLine("Any additonal doors?(y/n)");
                if (Console.ReadLine().ToLower().Contains("y"))
                {
                    Console.Write("Additional Door Access: ");
                    string userInput = Console.ReadLine().ToUpper();
                    NewAccess(newBadge,userInput);
                }
                else
                {
                    useTheDoorsLuke = false;
                }
            }
            bool added=BadgeDirectory.AddToDictionary(newBadge);
            if (added)
            {
                Console.WriteLine("New badge was succesfully added.");
            }
            else
            {
                Console.WriteLine("Failed to add badge.");
            }
            Continue();
            
        }
        private void NewAccess(Badge badge, string input)
        {
            badge.DoorAccess = $"{badge.DoorAccess} {input}";
        }

        private void InvalidSelection()
        {
            Console.Clear();
            Console.WriteLine("Please make a valid selection.");
            Continue();
        }
        private void Continue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void ExitProgram()
        {
            Console.Clear();
            Console.WriteLine("Now exiting the program. Have a nice day");
            Thread.Sleep(2000);
            Running = false;
        }
    }
}
