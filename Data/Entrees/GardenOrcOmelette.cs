using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class GardenOrcOmelette
    {
        public double Price { get; } = 4.57;

        public uint Calories { get; } = 404;

        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (Broccoli == false)
                {
                   instructions.Add("Hold broccoli");
                }
                else
                {
                    instructions.Remove("Hold broccoli");
                }
                if (Mushrooms == false)
                {
                   instructions.Add("Hold mushrooms");
                }
                else
                {
                    instructions.Remove("Hold mushrooms");
                }
                if (Tomato == false)
                {
                    instructions.Add("Hold tomato");
                }
                else
                {
                    instructions.Remove("Hold tomato");
                }
                if (Cheddar == false)
                {
                    instructions.Add("Hold cheddar");
                }
                else
                {
                    instructions.Remove("Hold cheddar");
                }
                return instructions;
            }
        }

        public bool Broccoli { get; set; } = true;

        public bool Mushrooms { get; set; } = true;

        public bool Tomato { get; set; } = true;

        public bool Cheddar { get; set; } = true;

        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

    }
}
