/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: DoubleDraugr.cs
* Purpose: To let cooks know what toppings the customer will want
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Attributes for the DoubleDraugr
    /// </summary>
    public class DoubleDraugr
    {
        /// <summary>
        /// gets the price
        /// </summary>
        public double Price => 7.32;

        /// <summary>
        /// gets the calories
        /// </summary>
        public uint Calories => 743;

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
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to return the "Double Draugr" string
        /// </summary>
        /// <returns>string name of burger</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
