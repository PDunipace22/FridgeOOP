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
            int userChoice;
            Fridge userFridge = new Fridge(false, "deluxe dispenser", 70, true);
            do
            {
                Console.WriteLine("Hello, welcome to the fridge app.");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1.");
                Console.WriteLine("To change the lightbulb, type 2.");
                Console.WriteLine("To clean, type 3.");
                Console.WriteLine("To take food, type 4.");
                Console.WriteLine("To check food supplies, type 5.");
                Console.WriteLine("To see all fridge details, type 6.");
                Console.WriteLine("To restart, type 7.");
                Console.WriteLine("To quit, type 8.");

                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        userFridge.DispenseWater();
                        break;
                    case 2:
                        Console.WriteLine(userFridge.ChangeBulbs());
                        break;
                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        break;
                    case 4:
                        Console.WriteLine("Enter the amount of food removed");
                        int amount = int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(amount);
                        break;
                    case 5:
                        Console.WriteLine(userFridge.CheckSupplies());
                        break;
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine(userFridge.Clean());
                        Console.WriteLine("Type of dispenser: " + userFridge.DispenserType);
                        Console.WriteLine("Remaining food amount: " + userFridge.FoodAmount);
                        Console.WriteLine("Bulbs: " + userFridge.BulbsWork);
                        break;
                }

            } while ((userChoice != 8) || (userChoice == 7));
        }
    }
}
