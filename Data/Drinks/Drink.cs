/*
* Author: John Wills
* Class name: Drink.cs
* Purpose: To be a BASE class for all of the drinks
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of Drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; } //ALL TEST ARE FAILING???

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>In US dollars</value>
        public abstract double Price { get;} //abstract vs virtual
                                                //Abstract knows going to have to override in other classes, virtual is getting away with not
        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get;}

        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
