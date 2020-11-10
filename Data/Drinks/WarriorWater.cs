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
    public class WarriorWater : Drink
    {
        private Size size;
        /*/// <summary>
        /// gets/sets size of drink
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }*/

        /// <summary>
        /// gets/sets price depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">Thrown for any unknown size</exception>
        public override double Price
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
        /// <exception cref="System.NotImplementedException">Thrown for any unknown calories</exception>
        public override uint Calories
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
        public override List<string> SpecialInstructions
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
        /// <returns>size + Warrior string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Warrior Water";
        }
    }
}
