using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class DoubleDraugr
    {
        public double Price { get; } = 7.32;

        public uint Calories { get; } = 843;

        public List<String> SpecialInstructions 
        { 
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
                if (Tomato == false)
                {
                    instructions.Add("Hold tomato");
                }
                else
                {
                    instructions.Remove("Hold tomato");
                }
                if (Lettuce == false)
                {
                    instructions.Add("Hold lettuce");
                }
                else
                {
                    instructions.Remove("Hold lettuce");
                }
                if (Mayo == false)
                {
                    instructions.Add("Hold mayo");
                }
                else
                {
                    instructions.Remove("Hold mayo");
                }
                return instructions;
            }
        }

        public bool Bun { get; set; } = true;

        public bool Ketchup { get; set; } = true;

        public bool Mustard { get; set; } = true;

        public bool Pickle { get; set; } = true;

        public bool Cheese { get; set; } = true;

        public bool Tomato { get; set; } = true;

        public bool Lettuce { get; set; } = true;

        public bool Mayo { get; set; } = true;

        public override string ToString()
        {
            return "Double Draugr";
        }

    }
}
