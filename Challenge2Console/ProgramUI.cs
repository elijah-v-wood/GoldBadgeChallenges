using Challenge2Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Console
{
    class ProgramUI
    {
        ClaimRepository claimRepository = new ClaimRepository();
        public void Run()
        {
            Seed();
            Menu();
        }


        private void Seed()
        {
            Console.WriteLine("Seeding Claims...");

            Claim c1 = new Claim(1, ClaimType.Car, "Accident on 465.", 400.00m, new DateTime(2018, 4, 25), new DateTime(2018, 4, 27));
            Claim c2 = new Claim(2, ClaimType.Home, "House fire in kitchen", 4000.00m, new DateTime(2018, 4, 11), new DateTime(2018, 4, 12));
            Claim c3 = new Claim(3, ClaimType.Theft, "Stolen Pancakes", 4.00m, new DateTime(2018, 4, 27), new DateTime(2018, 6, 1));

            claimRepository.AddtoQueue(c1);
            claimRepository.AddtoQueue(c2);
            claimRepository.AddtoQueue(c3);

        }
        private void Menu()
        {
            bool Running = true;
            while (Running)
            {
                
                Console.Clear();

                Console.WriteLine("Welcome Claims Agent!");

                Console.WriteLine("Please select from the following:\n" +
                    "1. See all Claims\n" +
                    "2. Take care of next Claim\n" +
                    "3. Enter a new Claim");

                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case string a when a.Contains("1"):
                    case string b when b.Contains("see"):
                    case string c when c.Contains("all"):
                        break;
                    case string d when d.Contains("2"):
                    case string e when e.Contains("next"):
                        break;
                    case string f when f.Contains("3"):
                    case string g when g.Contains("new"):
                        NewClaim();
                        break;

                    default:
                        InvalidSelection();
                        break;
                }
            
            }
        }
        private void NewClaim()
        {
            Console.Clear();
            string userInput;

            Console.WriteLine("Please enter the following: ");
            
            Console.Write("ID:: ");
            userInput = Console.ReadLine().ToLower();
            int claimID = int.Parse(userInput);

            Console.Write("Type: ");
            userInput = Console.ReadLine().ToLower();
            string claimType = userInput;

            Console.WriteLine("Description:");
            userInput = Console.ReadLine().ToLower();
            string description = userInput;

            Console.Write("Amount: ");
            userInput = Console.ReadLine().Replace("$","");
            decimal amnt = decimal.Parse(userInput);

            Console.Write("Date of Incident: ");
            string inc = Console.ReadLine();
            DateTime incident = DateTime.Parse(inc);

            Console.Write("Date of Claim: ");
            string clm = Console.ReadLine();
            DateTime claim = DateTime.Parse(clm);

            Claim newClaim = new Claim(claimID, claimType, description, amnt, incident, claim);
            if (newClaim.IsValid && newClaim.ClaimType!=ClaimType.NotValidType)
            {
                Console.WriteLine("This claim is valid!");
                Console.WriteLine("Press any key to add claim to the queue...");
                Console.ReadKey();
                claimRepository.AddtoQueue(newClaim);
            }
            else
            {
                Console.WriteLine("This claim is not valid are you sure want to enter it into the queue? (y/n)");
                userInput = Console.ReadLine();
                if (userInput.Contains("y"))
                {
                    Console.WriteLine("Item will be added to queue.");
                    claimRepository.AddtoQueue(newClaim);
                }
                else
                {
                    Console.WriteLine("Item will not be added to queue.");
                    Continue();
                }
            }


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
    }
}
