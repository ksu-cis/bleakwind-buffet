/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: SailorSoda.cs
* Purpose: Show size options and ice for the drink
*/
using BleakwindBuffet.Data.Enums;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Sailor Soda properties
    /// </summary>
    public class SailorSoda
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
                if (size == Size.Small) return 1.42;
                if (size == Size.Medium) return 1.74;
                if (size == Size.Large) return 2.07;
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
                if (size == Size.Small) return 117;
                if (size == Size.Medium) return 153;
                if (size == Size.Large) return 205;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// gets/sets if they want ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Accesses the SodaFlavor class to get/set the soda flavor, cherry as default
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry; //Correct??

        /// <summary>
        /// creates list of instructions for staff
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to return the "Sailor Soda" string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " " + Flavor + " Sailor Soda";
        }
    }
}
