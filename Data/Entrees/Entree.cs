/*
* Author: John Wills
* Class name: Entree.cs
* Purpose: To be a BASE class for all of the entrees
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing common properties of all of the entree classes
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Price of the entrees
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the entrees
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for the entrees
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
