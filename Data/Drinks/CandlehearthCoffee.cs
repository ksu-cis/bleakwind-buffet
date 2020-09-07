/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: CandlehearthCoffee.cs
* Purpose: Show size options and ice for the drink, with cream and decaf as options
*/
using BleakwindBuffet.Data.Enums;
//using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Properties of coffee
    /// </summary>
    public class CandlehearthCoffee
    {
        private Size size;
        /// <summary>
        /// gets/sets size of drink
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// gets/sets price depending on size
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 0.75;
                if (size == Size.Medium) return 1.25;
                if (size == Size.Large) return 1.75;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// gets calories depending on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 7;
                if (size == Size.Medium) return 10;
                if (size == Size.Large) return 20;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// gets/sets if they want ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// gets/sets if they want room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// gets/sets if they want their coffee decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// creates list of instructions for staff
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                //if (Decaf) instructions.Add("Make decaf");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to return the "Candlehearth Coffee" string
        /// </summary>
        /// <returns>size + if decaf + candlehearth</returns>
        public override string ToString()
        {
            string t1 = "";
            if(Decaf)
            {
                t1 = " Decaf";
            }
            return Size.ToString() + t1 + " Candlehearth Coffee";
        }
    }
}
