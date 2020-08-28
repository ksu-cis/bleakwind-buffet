using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class PhillyPoacher
    {
        public double Price { get; } = 7.23;

        public uint Calories { get; } = 784;

        public List<String> SpecialInstructions {
            get
            {
                List<String> instructions = new List<String>();
                if (Sirloin == false)
                {
                    instructions.Add("Hold sirloin");
                }
                else
                {
                    instructions.Remove("Hold sirloin");
                }
                if (Onion == false)
                {
                    instructions.Add("Hold onions");
                }
                else
                {
                    instructions.Remove("Hold onions");
                }
                if (Roll == false)
                {
                    instructions.Add("Hold roll");
                }
                else
                {
                    instructions.Remove("Hold roll");
                }
                return instructions;
            }
        }

        public bool Sirloin { get; set; } = true;

        public bool Onion { get; set; } = true;

        public bool Roll { get; set; } = true;

        public override string ToString()
        {
            return "Philly Poacher";
        }

    }
}
