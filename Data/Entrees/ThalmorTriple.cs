/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: ThalmorTriple.cs
* Purpose: Let cooks know what the customer wants on their burger
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Attributes for the ThalmorTriple
    /// </summary>
    public class ThalmorTriple
    {
        /// <summary>
        /// gets the price
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// gets the calories
        /// </summary>
        public uint Calories => 943;

        /// <summary>
        /// Gets/sets if they want ketchup on the burger
        /// </summary>
        public bool Ketchup { get; set; } = true;


        /// <summary>
        /// Gets/sets if they want bun on the burger
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Gets/sets if they want mustard on the burger
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Gets/sets if they want pickle on the burger
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Gets/sets if they want cheese on the burger
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        ///  Gets/sets if they want tomato on the burger
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        ///  Gets/sets if they want lettuce on the burger
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        ///  Gets/sets if they want mayo on the burger
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// gets/sets if they want bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// gets/sets if they want egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// List of special instructions that will determine what is on the burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to return the "Thalmor Triple" string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
