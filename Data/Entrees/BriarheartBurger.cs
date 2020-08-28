using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class BriarheartBurger
    {
        public double Price { get; } = 6.32;

        public uint Calories { get; } = 743;

        public List<String> SpecialInstructions { 
            get
            {
                List<String> instructions = new List<String>();
                if (Bun == false)
                {
                    instructions.Add("Hold bun");
                }
                else
                {
                    instructions.Remove("Hold bun");
                }
                if (Ketchup == false)
                {
                    instructions.Add("Hold ketchup");
                }
                else
                {
                    instructions.Remove("Hold ketchup");
                }
                if (Mustard == false)
                {
                    instructions.Add("Hold mustard");
                }
                else
                {
                    instructions.Remove("Hold mustard");
                }
                if (Pickle == false)
                {
                    instructions.Add("Hold pickle");
                }
                else
                {
                    instructions.Remove("Hold pickle");
                }
                if (Cheese == false)
                {
                    instructions.Add("Hold cheese");
                }
                else
                {
                    instructions.Remove("Hold cheese");
                }
                return instructions;
            }
        }

        public bool Bun { get; set; } = true;

        public bool Ketchup { get; set; } = true;

        public bool Mustard { get; set; } = true;

        public bool Pickle { get; set; } = true;

        public bool Cheese { get; set; } = true;

        public override string ToString()
        {
            return "Briarheart Burger";
        }

    }
}
