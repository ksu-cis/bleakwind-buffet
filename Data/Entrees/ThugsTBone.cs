using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class ThugsTBone
    {
        public double Price { get; } = 6.44;

        public uint Calories { get; } = 982;

        public List<String> SpecialInstructions
        {
            get
            {
                return new List<String>();
            }
        }

        public override string ToString()
        {
            return "Thugs T-Bone";
        }

    }
}