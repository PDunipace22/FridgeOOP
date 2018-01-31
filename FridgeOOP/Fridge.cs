using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    public class Fridge
    {
        //fields
        private bool isClean;
        private string dispenserType;
        private int foodAmount;
        private bool bulbsWork;

        //Properties
        public bool IsClean
        {
            get { return this.isClean; }
            set { this.isClean = value; }
        }

        public string DispenserType
        {
            get { return this.dispenserType; }
        }

        public int FoodAmount
        {
            get { return this.foodAmount; }
            set { this.foodAmount = value; }
        }

        public bool BulbsWork
        {
            get { return this.bulbsWork; }
            set { this.bulbsWork = value; }
        }

        //Constructors
        public Fridge()
        {
            this.dispenserType = "basic water dispenser";
        }

        public Fridge(string dispenserType)
        {
            this.dispenserType = dispenserType;
        }

        public Fridge(bool isClean, string dispenserType, int foodAmount, bool bulbsWork)
        {
            this.isClean = isClean;
            this.dispenserType = dispenserType;
            this.foodAmount = foodAmount;
            this.bulbsWork = bulbsWork;
        }

        //Methods()
        public void DispenseWater()
        {
            if(dispenserType == "basis water dispenser")
            {
                Console.WriteLine("Here's some lukewarm water!");
            }
            else if(dispenserType == "deluxe dispenser")
            {
                Console.WriteLine("Enjoy your perfect ice water.");
            }
            else
            {
                Console.WriteLine("What's gonna come out? It's a surprise!");
            }
        }

        public string ChangeBulbs()
        {
            if(bulbsWork == false)
            {
                bulbsWork = true;
                return "The bulbs have changed";
            }
            else
            {
                return "The bulbs don't have to be changed";
            }
        }

        public void RemoveFood(int foodRemoved)
        {
            foodAmount -= foodRemoved;
        }

        public string CheckSupplies()
        {
            if (foodAmount >= 80)
            {
                return "fully stocked";
            }
            else if (foodAmount > 40)
            {
                return "getting low";
            }
            else
            {
                return "time to grocery stop";
            }
        }

        public string Clean()
        {
            if (isClean == false)
            {
                isClean = true;
                return "I cleaned the fridge.";
            }
            else
            {
                return "The fridge is already clean.";
            }
        }
    }
}
