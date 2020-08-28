using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    class DragonbornWaffleFries
    {

        public double price;
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 0.42;
                }
                else if (Size == Size.Medium)
                {
                    price = 0.76;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 0.96;
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
                    calories = 77;
                }
                else if (Size == Size.Medium)
                {
                    calories = 89;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 100;
                    }
                }
                return calories;
            }
        }

        public Size Size { get; set; } = Size.Small;

        public override string ToString()
        {
            return Size + " Dragonborn Waffle Fries";
        }

    }
}
