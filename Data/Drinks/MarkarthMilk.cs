using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class MarkarthMilk
    {

        public double price;
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.05;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.11;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 1.22;
                    }
                }
                return price;
            }  
        }

        public uint calories;
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 56;
                }
                else if (Size == Size.Medium)
                {
                    calories = 72;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 93;
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
                if (Ice == true)
                {
                    instructions.Add("Add ice");
                }
                else
                {
                    instructions.Remove("Add ice");
                }
                return instructions;
            }
        }

        public bool Ice { get; set; } = false;

        public Size Size { get; set; } = Size.Small;

        public override string ToString()
        {
            return Size + " Markarth Milk";
        }

    }
}
