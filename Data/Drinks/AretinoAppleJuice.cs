using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class AretinoAppleJuice
    {

        public double price;
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 0.62;
                }
                else if (Size == Size.Medium)
                {
                    price = 0.87;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 1.01;
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
                    calories = 44;
                }
                else if (Size == Size.Medium)
                {
                    calories = 88;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 132;
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

        public bool Ice { get; set; } = true;

        public Size Size { get; set; } = Size.Small;

        public override string ToString()
        {
            return Size + " Aretino Apple Juice";
        }

    }
}
