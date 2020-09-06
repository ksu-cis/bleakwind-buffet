/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: WarriorWater.cs
* Purpose: Show size options and ice for the drink
*/
using BleakwindBuffet.Data.Enums;
//using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Properties of Water
    /// </summary>
    public class WarriorWater
    {
        private Size size;
        /// <summary>
        /// gets/sets size of drink
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// gets/sets price depending on size
        /// </summary>
        public double price
        {
            get
            {
                if (size == Size.Small) return 0.00;
                if(size == Size.Medium) return 0.00;
                if(size == Size.Large) return 0.00;
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
                if (size == Size.Small) return 0;
                if (size == Size.Medium) return 0;
                if (size == Size.Large) return 0;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// gets/sets if they want ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// gets/sets if they want lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// creates list of instructions for staff
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to return the "Warrior Water" string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Warrior Water";
        }
    }
}
