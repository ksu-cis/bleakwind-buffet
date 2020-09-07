/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: PhillyPoacher.cs
* Purpose: show what comes with the item and if anything needs to be removed
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Attributes for the PhillyPoacher
    /// </summary>
    public class PhillyPoacher
    {
        /// <summary>
        /// gets the price
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// gets the calories
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// gets/sets if they want the sirloin
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// gets/sets if they want onion
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// gets/sets if they want a roll
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// List of special instructions that will determine what is on the order
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to return the "Philly Poacher" string
        /// </summary>
        /// <returns>string name of entree</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
