﻿/*
* Author: John Wills
* Edited by: (Only include if you are not the original author)
* Class name: ThugsTBone.cs
* Purpose: Only the steak with no booleans
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Attributes for the ThugsTBone
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// gets price
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// gets calories
        /// </summary>
        public uint Calories => 982;

        /// <summary>
        /// returns empty list of instructions
        /// </summary>
        public List<string> SpecialInstructions => new List<string>(); //Did I do this correctly?

        /// <summary>
        /// Overrides the ToString() method to return the "Thugs T-Bone" string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}