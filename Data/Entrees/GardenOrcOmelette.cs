/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: GardenOrcOmelette.cs
* Purpose: List what toppings come with the omelette and if anything should be removed
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Attributes for the GardenOrcOmelette
    /// </summary>
    public class GardenOrcOmelette
    {
        /// <summary>
        /// gets price
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// gets calories
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// gets/sets if they want broccoli
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// gets/sets if they want mushrooms
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// gets/sets if they want tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        //gets/sets if they want cheddar
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// List of special instructions that will determine what is on the order
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to return the "Graden Orc Omelette" string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
