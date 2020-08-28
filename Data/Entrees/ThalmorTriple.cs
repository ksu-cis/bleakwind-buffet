using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class ThalmorTriple
    {
        public double Price { get; } = 8.32;

        public uint Calories { get; } = 943;

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
                if (Bacon == false)
                {
                    instructions.Add("Hold bacon");
                }
                else
                {
                    instructions.Remove("Hold bacon");
                }
                if (Egg == false)
                {
                    instructions.Add("Hold egg");
                }
                else
                {
                    instructions.Remove("Hold egg");
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

        public bool Bacon { get; set; } = true;

        public bool Egg { get; set; } = true;

        public override string ToString()
        {
            return "Thalmor Triple";
        }

    }
}
