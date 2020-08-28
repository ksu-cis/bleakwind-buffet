using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class WarriorWater
    {
        public double Price { get; } = 0;

        public uint Calories { get; } = 0;

        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (Ice == false)
                {
                    instructions.Add("Hold ice");
                }
                else
                {
                    instructions.Remove("Hold ice");
                }
                if (Lemon == true)
                {
                    instructions.Add("Add lemon");
                }
                else
                {
                    instructions.Remove("Add lemon");
                }
                return instructions;
            }
        }

        public bool Ice { get; set; } = true;

        public bool Lemon { get; set; } = false;

        public Size Size { get; set; } = Size.Small;

        public override string ToString()
        {
            return Size + " Warrior Water";
        }

    }
}