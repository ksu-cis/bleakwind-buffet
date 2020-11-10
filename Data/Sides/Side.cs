/*
* Author: John Wills
* Class name: Side.cs
* Purpose: To be a BASE class for all of the sides
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// An abstract base class that shares the common properties of all side classes
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions of the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
