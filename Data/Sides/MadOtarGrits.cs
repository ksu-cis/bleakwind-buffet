/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: MadOtarGrits.cs
* Purpose: Show size/price options and calories for the side
*/
using BleakwindBuffet.Data.Enums;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    /// <summary>
    /// Properties of grits
    /// </summary>
    public class MadOtarGrits
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
                if (size == Size.Small) return 1.22;
                if (size == Size.Medium) return 1.58;
                if (size == Size.Large) return 1.93;
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
                if (size == Size.Small) return 105;
                if (size == Size.Medium) return 142;
                if (size == Size.Large) return 179;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// adds size and name of dish to ToString() method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Mad Otar Grits";
        }
    }
}

