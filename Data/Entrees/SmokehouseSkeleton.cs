﻿/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: SmokehouseSkeleton.cs
* Purpose: Show what comes on the breakfast item and if anything needs to be removed
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Attributes for the SmokehouseSkeleton
    /// </summary>
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        /// gets the price
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// gets the calories
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// gets/sets if they want sausage
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// gets/sets if they want egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// gets/sets if they want hashbrowns
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// gets/sets if they want a pancake
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// List of special instructions that will determine what is on the order
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to return the "Smokehouse Skeleton" string
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
