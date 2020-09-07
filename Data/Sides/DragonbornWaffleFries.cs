/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: DragonbornWaffleFries.cs
* Purpose: Show size/price options and calories for the side
*/
using BleakwindBuffet.Data.Enums;
//using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Properties of waffle fries
    /// </summary>
    public class DragonbornWaffleFries
    {
        private Size size;
        /// <summary>
        /// gets/sets size of salad
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// gets price depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">Thrown for any unknown size</exception>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 0.42;
                if (size == Size.Medium) return 0.76;
                if (size == Size.Large) return 0.96;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// gets calories depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">Thrown for any unknown calories</exception>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 77;
                if (size == Size.Medium) return 89;
                if (size == Size.Large) return 100;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// adds size and name of dish to ToString() method
        /// </summary>
        /// <returns>size + name of side</returns>
        public override string ToString()
        {
            return Size.ToString() + " Dragonborn Waffle Fries";
        }
    }
}
