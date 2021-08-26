using Challenge4Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge4Console
{
    public class ProgramUI
    {
        OutingRepository outingRepository = new OutingRepository();
        bool Running = true;
        public void Run()
        {
            Seed();
            Menu();
        }

        public void Menu()
        {
            while (Running)
            {

                Console.Clear();

                Console.WriteLine("Welcome!");

                Console.WriteLine("Please select from the following:\n" +
                    "1. Display all outings\n" +
                    "2. Add an Outing\n" +
                    "3. Total Cost of Outings\n" +
                    "4. Exit the program");

                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case string a when a.Contains("1"):
                    case string b when b.Contains("display"):
                        DisplayAllOutings();
                        break;
                    case string d when d.Contains("2"):
                    case string e when e.Contains("add"):
                        AddOuting();
                        break;
                    case string f when f.Contains("3"):
                    case string c when c.Contains("all"):
                    case string g when g.Contains("total"):
                        CostCalculator();
                        break;
                    case string i when i.Contains("4"):
                    case string j when j.Contains("exit"):
                        Console.WriteLine("Exiting the program.");
                        Thread.Sleep(1000);
                        Exit();
                        break;
                    default:
                        Console.Clear();
                        InvalidSelection();
                        break;

                }
                




            }
        }
        private void Seed()
        {
            Outing out1 = new Outing(EventType.Golf, 2000m, 15, 50m, new DateTime(2018, 04, 23));
            Outing out2 = new Outing(EventType.Golf, 1800m, 25, 50m, new DateTime(2019, 04, 23));
            Outing out3 = new Outing(EventType.AmusementPark, 3000m, 60, 110m, new DateTime(2021, 05, 22));
            Outing out4 = new Outing(EventType.Bowling, 500m, 30, 20m, new DateTime(2020, 08, 13));

            outingRepository.AddOuting(out1);
            outingRepository.AddOuting(out2);
            outingRepository.AddOuting(out3);
            outingRepository.AddOuting(out4);

        }
        private void DisplayAllOutings()
        {
            Console.Clear();

            List<Outing> outingList = outingRepository.GetOut();

            foreach(Outing outing in outingList)
            {
                Console.WriteLine($"{outing.Event} Date: {outing.DateOfEvent.ToString("d")}\n" +
                    $"Total Cost: {outing.TotalCost} Attendees: {outing.Attendees}\n" +
                    $"Event Cost: {outing.EventCost} Cost per Attendee: {outing.CostPerHead}");
                Console.WriteLine("\n");

            }
            Continue();
        }
        private void CostCalculator()
        {
            Console.Clear();
            Console.WriteLine("Please select one of the following categories:\n" +
                "Events:\n" +
                "1. All\n" +
                "2. Golf\n" +
                "3. Bowling\n" +
                "4. Amusement Parks\n" +
                "5. Concerts\n");
            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case string a when a.Contains("1"):
                case string b when b.Contains("all"):
                    decimal allCost = outingRepository.GrandTotal();
                    Console.WriteLine($"${allCost}");
                    Continue();
                    break;
                case string c when c.Contains("2"):
                case string d when d.Contains("golf"):
                    decimal golfCost = outingRepository.GrandTotalByType(EventType.Golf);
                    Console.WriteLine($"The Total cost of Golf events are: ${golfCost}");
                    Continue();
                    break;
                case string e when e.Contains("3"):
                case string f when f.Contains("bowling"):
                    decimal bowlCost = outingRepository.GrandTotalByType(EventType.Bowling);
                    Console.WriteLine($"The Total cost of Bowling events are: ${bowlCost}");
                    Continue();
                    break;
                case string g when g.Contains("4"):
                case string h when h.Contains("amusement"):
                    decimal amuseCost = outingRepository.GrandTotalByType(EventType.AmusementPark);
                    Console.WriteLine($"The Total cost of Amusement Parks are: ${amuseCost}");
                    Continue();
                    break;
                case string i when i.Contains("5"):
                case string j when j.Contains("concert"):
                    decimal concertCost = outingRepository.GrandTotalByType(EventType.Concert);
                    Console.WriteLine($"The Total cost of Concerts are: ${concertCost}");
                    Continue();
                    break;
            }
        }
        private void AddOuting()
        {
            Console.Clear();
            Console.WriteLine("Please enter the folowing for the new outing:");

            Console.Write("Type of Event: ");
            string type = Console.ReadLine().ToLower();

            Console.Write("Event Cost: ");
            string cost = Console.ReadLine().ToLower();

            Console.Write("Attendees: ");
            string attendees = Console.ReadLine().ToLower();

            Console.Write("Cost per Person: ");
            string perHead = Console.ReadLine().ToLower();

            Console.Write("Date(YYYY-MM-DD): ");
            string date = Console.ReadLine().ToLower();

            Outing newOut = new Outing(type, cost, attendees, perHead, date);
            bool added = outingRepository.AddOuting(newOut);
            if (added)
            {
                Console.WriteLine("Outing successfully added!");
                if (newOut.Event == EventType.NoType)
                {
                    Console.WriteLine("Failed to properly set event type.");
                }
            }
            else
            {
                Console.WriteLine("Failed to add outing.");
            }
            Continue();
        }

        private void Exit()
        {
            Console.Clear();

            Console.WriteLine("Have a nice day!");
            Thread.Sleep(2000);

            Running = false;
        }
        private void Continue()
        {
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
        private void InvalidSelection()
        {
            Console.WriteLine("Please ensure a proper selection has been made.");
            Continue();
        }
    } 
}
