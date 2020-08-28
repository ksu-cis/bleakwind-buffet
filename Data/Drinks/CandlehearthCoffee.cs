using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class CandlehearthCoffee
    {
        public double Price
        {
            get
            {
                return Price;
            }
            set
            {
                if (Size == Size.Small)
                {
                    Price = 0.75;
                }
                else if (Size == Size.Medium)
                {
                    Price = 1.25;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        Price = 1.75;
                    }
                }
            }
        }

        public uint calories;
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 7;
                }
                else if (Size == Size.Medium)
                {
                    calories = 10;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 20;
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
                if (RoomForCream == false)
                {
                    instructions.Add("Add cream");
                }
                else
                {
                    instructions.Remove("Add cream");
                }
                return instructions;
            }
        }

        public bool Ice { get; set; } = false;

        public bool RoomForCream { get; set; } = false;

        public bool Decaf { get; set; } = false;

        public Size Size { get; set; } = Size.Small;

        public override string ToString()
        {
            if (Decaf == true)
            {
                return Size + " Decaf Candlehearth Coffee";
            }
            else
            {
                return Size + " Candlehearth Coffee";
            }
        }

    }
}
