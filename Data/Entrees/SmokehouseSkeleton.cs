using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class SmokehouseSkeleton
    {
        public double Price { get; } = 5.62;

        public uint Calories { get; } = 602;

        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (SausageLink == false)
                {
                    instructions.Add("Hold sausage");
                }
                else
                {
                    instructions.Remove("Hold sausage");
                }
                if (Egg == false)
                {
                    instructions.Add("Hold eggs");
                }
                else
                {
                    instructions.Remove("Hold eggs");
                }
                if (Hashbrown == false)
                {
                    instructions.Add("Hold hash browns");
                }
                else
                {
                    instructions.Remove("Hold hash browns");
                }
                if (Pancake == false)
                {
                    instructions.Add("Hold pancakes");
                }
                else
                {
                    instructions.Remove("Hold pancakes");
                }
                return instructions;
            }
        }

        public bool SausageLink { get; set; } = true;

        public bool Egg { get; set; } = true;

        public bool Hashbrown { get; set; } = true;

        public bool Pancake { get; set; } = true;

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }

    }
}
