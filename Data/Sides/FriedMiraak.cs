/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: FriedMiraak.cs
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
    /// properites of fried miraak
    /// </summary>
    public class FriedMiraak
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
                if (size == Size.Small) return 1.78;
                if (size == Size.Medium) return 2.01;
                if (size == Size.Large) return 2.88;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// gets calories depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">Thrown for any unknown cal</exception>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 151;
                if (size == Size.Medium) return 236;
                if (size == Size.Large) return 306;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// adds size and name of dish to ToString() method
        /// </summary>
        /// <returns>size + name of dish</returns>
        public override string ToString()
        {
            return Size.ToString() + " Fried Miraak";
        }
    }
}
