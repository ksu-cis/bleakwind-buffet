/*
 * Author: John Wills
 * Class: Menu.cs
 * Purpose: Be the menu
 */
using BleakwindBuffet.Data.Drinks;
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
            entrees.Add(tb);
            return entrees;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            FriedMiraak fm = new FriedMiraak();
            MadOtarGrits mg = new MadOtarGrits();
            VokunSalad vs = new VokunSalad();

            DragonbornWaffleFries wf1 = new DragonbornWaffleFries();
            FriedMiraak fm1 = new FriedMiraak();
            MadOtarGrits mg1 = new MadOtarGrits();
            VokunSalad vs1 = new VokunSalad();

            DragonbornWaffleFries wf2 = new DragonbornWaffleFries();
            FriedMiraak fm2 = new FriedMiraak();
            MadOtarGrits mg2 = new MadOtarGrits();
            VokunSalad vs2 = new VokunSalad();

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
                    wf1.Size = s;
                    fm1.Size = s;
                    mg1.Size = s;
                    vs1.Size = s;
                    sides.Add((IOrderItem)wf1);
                    sides.Add((IOrderItem)fm1);
                    sides.Add((IOrderItem)mg1);
                    sides.Add((IOrderItem)vs1);
                }
                s = Size.Large;
                if (s == Size.Large)
                {
                    wf2.Size = s;
                    fm2.Size = s;
                    mg2.Size = s;
                    vs2.Size = s;
                    sides.Add((IOrderItem)wf2);
                    sides.Add((IOrderItem)fm2);
                    sides.Add((IOrderItem)mg2);
                    sides.Add((IOrderItem)vs2);
                }
                valid = false;
            }
            return sides;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            CandlehearthCoffee cf = new CandlehearthCoffee();
            MarkarthMilk mm = new MarkarthMilk();
            SailorSoda ss = new SailorSoda();
            WarriorWater ww = new WarriorWater();

            AretinoAppleJuice aj1 = new AretinoAppleJuice();
            CandlehearthCoffee cf1 = new CandlehearthCoffee();
            MarkarthMilk mm1 = new MarkarthMilk();
            SailorSoda ss1 = new SailorSoda();
            WarriorWater ww1 = new WarriorWater();

            AretinoAppleJuice aj2 = new AretinoAppleJuice();
            CandlehearthCoffee cf2 = new CandlehearthCoffee();
            MarkarthMilk mm2 = new MarkarthMilk();
            SailorSoda ss2 = new SailorSoda();
            WarriorWater ww2 = new WarriorWater();

            bool valid = true;
            while (valid)
            {
                Size s = Size.Small;
                if (s == Size.Small)
                {
                    aj.Size = s;
                    cf.Size = s;
                    mm.Size = s;
                    ss.Size = s;
                    ww.Size = s;
                    drinks.Add((IOrderItem)aj);
                    drinks.Add((IOrderItem)cf);
                    drinks.Add((IOrderItem)mm);
                    drinks.Add((IOrderItem)ss);
                    drinks.Add((IOrderItem)ww);
                }
                s = Size.Medium;
                if (s == Size.Medium)
                {
                    aj1.Size = s;
                    cf1.Size = s;
                    mm1.Size = s;
                    ss1.Size = s;
                    ww1.Size = s;
                    drinks.Add((IOrderItem)aj1);
                    drinks.Add((IOrderItem)cf1);
                    drinks.Add((IOrderItem)mm1);
                    drinks.Add((IOrderItem)ss1);
                    drinks.Add((IOrderItem)ww1);
                }
                s = Size.Large;
                if (s == Size.Large)
                {
                    aj2.Size = s;
                    cf2.Size = s;
                    mm2.Size = s;
                    ss2.Size = s;
                    ww2.Size = s;
                    drinks.Add((IOrderItem)aj2);
                    drinks.Add((IOrderItem)cf2);
                    drinks.Add((IOrderItem)mm2);
                    drinks.Add((IOrderItem)ss2);
                    drinks.Add((IOrderItem)ww2);
                }
                valid = false;
            }

            return drinks;
        }

        public static IEnumerable<IOrderItem> FullMenu()
        {
            throw new NotImplementedException();
        }
    }
}
