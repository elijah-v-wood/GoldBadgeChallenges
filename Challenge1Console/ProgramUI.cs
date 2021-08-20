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
        public void Run()
        {
            while (runFlag) 
            {
                Console.WriteLine("Welcome!\n Please Select from a list of options below:\n"
                    + "1. Add New Menu Item\n"
                    + "2. Get Menu Items"
                    + "3. Remove an Item from the menu"
                    + "4. Exit the Program");
                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case string a when a.Contains("1"):
                    case string b when b.Contains("add"):
                    case string c when c.Contains("new"):
                        Console.WriteLine("DEBUG((REMOVE LATER)) selection 1");
                        break;
                    case string d when d.Contains("2"):
                    case string e when e.Contains("menu"):
                    case string f when f.Contains("get"):
                        Console.WriteLine("DEBUG((REMOVE LATER)) selection 2");
                        break;
                    case string g when g.Contains("3"):
                    case string h when h.Contains("delete"):
                    case string i when i.Contains("remove"):
                        Console.WriteLine("DEBUG((REMOVE LATER)) selection 3");
                        break;
                    case string j when j.Contains("4"):
                    case string k when k.Contains("exit"):
                    case string l when l.Contains("leave"):
                        Console.WriteLine("DEBUG((REMOVE LATER)) selection 4");
                        Thread.Sleep(1000);
                        Exit();
                        break;
                }
            
            }
            
        }
        private void Exit()
        {
            Console.Clear();

            Console.WriteLine("Have a nice day!");
            Thread.Sleep(2000);

            runFlag = false;
        }
    }
}
