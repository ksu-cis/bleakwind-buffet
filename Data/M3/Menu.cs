/*
 * Author: John Wills
 * Class: Menu.cs
 * Purpose: Be the menu
 */
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette goc = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone tb = new ThugsTBone();

            entrees.Add((IOrderItem)bb);
            entrees.Add((IOrderItem)dd);
            entrees.Add((IOrderItem)goc);
            entrees.Add((IOrderItem)pp);
            entrees.Add((IOrderItem)ss);
            entrees.Add((IOrderItem)tt);
            entrees.Add((IOrderItem)tb);
            return entrees;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            FriedMiraak fm = new FriedMiraak();
            MadOtarGrits mg = new MadOtarGrits();
            VokunSalad vs = new VokunSalad();
            
            bool valid = true;
            while(valid)
            {
                Size s = Size.Small;
                if (s == Size.Small)
                {
                    wf.Size = s;
                    fm.Size = s;
                    mg.Size = s;
                    vs.Size = s;
                    sides.Add((IOrderItem)wf);
                    sides.Add((IOrderItem)fm);
                    sides.Add((IOrderItem)mg);
                    sides.Add((IOrderItem)vs);
                }
                s = Size.Medium;
                if (s == Size.Medium)
                {
                    wf.Size = s;
                    fm.Size = s;
                    mg.Size = s;
                    vs.Size = s;
                    sides.Add((IOrderItem)wf);
                    sides.Add((IOrderItem)fm);
                    sides.Add((IOrderItem)mg);
                    sides.Add((IOrderItem)vs);
                }
                s = Size.Large;
                if (s == Size.Large)
                {
                    wf.Size = s;
                    fm.Size = s;
                    mg.Size = s;
                    vs.Size = s;
                    sides.Add((IOrderItem)wf);
                    sides.Add((IOrderItem)fm);
                    sides.Add((IOrderItem)mg);
                    sides.Add((IOrderItem)vs);
                }
            }
            return sides;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<IOrderItem> FullMenu()
        {
            throw new NotImplementedException();
        }
    }
}
