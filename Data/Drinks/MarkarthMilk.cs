/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: MarkarthMilk.cs
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
    /// Properties of milk
    /// </summary>
    public class MarkarthMilk : Drink
    {
        private Size size;
        /*/// <summary>
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
        }*/

        /// <summary>
        /// gets/sets price depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">Thrown for any unknown price</exception>
        public override double Price
        {
            get
            {
                if (size == Size.Small) return 1.05;
                if (size == Size.Medium) return 1.11;
                if (size == Size.Large) return 1.22;
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
                if (size == Size.Small) return 56;
                if (size == Size.Medium) return 72;
                if (size == Size.Large) return 93;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// gets/sets if they want ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// creates list of instructions for staff
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to return the "Markarth Milk" string
        /// </summary>
        /// <returns>size + markarth milk string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Markarth Milk";
        }
    }
}
