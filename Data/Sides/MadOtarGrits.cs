using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    class MadOtarGrits
    {

        public double price;
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.22;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.58;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 1.93;
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
                    calories = 105;
                }
                else if (Size == Size.Medium)
                {
                    calories = 142;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 179;
                    }
                }
                return calories;
            }
        }

        public Size Size { get; set; } = Size.Small;

        public override string ToString()
        {
            return Size + " Mad Otar Grits";
        }

    }
}
