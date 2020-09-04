/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: VokunSalad.cs
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
    /// properties of salad
    /// </summary>
    public class VokunSalad
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
        public double Price
        {
            get
            {
                if (size == Size.Small) return 0.92;
                if (size == Size.Medium) return 1.28;
                if (size == Size.Large) return 1.82;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// gets calories depending on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 41;
                if (size == Size.Medium) return 52;
                if (size == Size.Large) return 73;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// adds size and name of dish to ToString() method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Volkun Salad";
        }
    }
}
