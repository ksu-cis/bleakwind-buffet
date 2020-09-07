/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: BriarheartBurger.cs
* Purpose: To show all toppings on the burger and let cooks know what they want
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Attributes for the BriarheartBurger
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 6.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories => 732;

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
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to return the "Briarheart Burger" string
        /// </summary>
        /// <returns>string name of burger</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
