using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    class FriedMiraak
    {

        public double price;
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.78;
                }
                else if (Size == Size.Medium)
                {
                    price = 2.01;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 2.88;
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
                    calories = 151;
                }
                else if (Size == Size.Medium)
                {
                    calories = 236;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 306;
                    }
                }
                return calories;
            }
        }

        public Size Size { get; set; } = Size.Small;

        public override string ToString()
        {
            return Size + " Fried Miraak";
        }

    }
}
