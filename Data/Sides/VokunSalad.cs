using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    class VokunSalad
    {

        public double price;
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 0.93;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.28;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 1.82;
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
                    calories = 41;
                }
                else if (Size == Size.Medium)
                {
                    calories = 52;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 73;
                    }
                }
                return calories;
            }
        }

        public Size Size { get; set; } = Size.Small;

        public override string ToString()
        {
            return Size + " Vokun Salad";
        }

    }
}
