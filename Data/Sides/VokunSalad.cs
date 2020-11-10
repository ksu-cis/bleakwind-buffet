﻿/*
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
    public class VokunSalad : Side
    {
        private Size size;
        /*/// <summary>
        /// gets/sets size of salad
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }*/

        /// <summary>
        /// gets price depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">Thrown for any unknown size</exception>
        public override double Price
        {
            get
            {
                if (size == Size.Small) return 0.93;
                if (size == Size.Medium) return 1.28;
                if (size == Size.Large) return 1.82;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// gets calories depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">Thrown for any unknown cal</exception>
        public override uint Calories
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
        /// Side = return empty list
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// adds size and name of dish to ToString() method
        /// </summary>
        /// <returns>size + name of dish</returns>
        public override string ToString()
        {
            return Size.ToString() + " Vokun Salad";
        }
    }
}
