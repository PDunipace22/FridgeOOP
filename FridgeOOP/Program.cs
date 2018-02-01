using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an interactive console window
            //Prompt user to choose what to do with the fridge
            //Call methods on fridge object to do what the user wants

            Console.WriteLine("Hello, welcome to the fridge app.");
            Console.WriteLine("What would you like to do with your fridge?");
            Console.WriteLine("To dispense water, type 1.");
            Console.WriteLine("To change the lightbulb, type 2.");
            Console.WriteLine("To clean, type 3.");
            Console.WriteLine("To take food, type 4.");
            Console.WriteLine("To check food supplies, type 5.");
            Console.WriteLine("To see all fridge details, type 6.");
            Console.WriteLine("To quit, type 7.");
        }
    }
}
