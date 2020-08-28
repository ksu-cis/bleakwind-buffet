using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class SailorSoda
    {

        public double price;
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.42;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.74;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 2.07;
                    }
                }
                return price;
            }
        }

        public uint calories;
        public uint Calories {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 117;
                }
                else if (Size == Size.Medium)
                {
                    calories = 153;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 205;
                    }
                }
                return calories;
            }
        }

        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (Ice == false)
                {
                    instructions.Add("Hold ice");
                }
                else
                {
                    instructions.Remove("Hold ice");
                }
                return instructions;
            }
        }

        public bool Ice { get; set; } = true;

        public Size Size { get; set; } = Size.Small;

        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

        public override string ToString()
        {
            return Size + " " + Flavor + " Sailor Soda";
        }

    }
}
