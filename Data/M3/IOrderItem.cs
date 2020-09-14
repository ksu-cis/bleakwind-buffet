/*
 * Author: John Wills
 * Class: IOrderItem.cs
 * Purpose: Be the interface
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem
    {
        double Price { get; }

        uint Calories { get; }

        List<string> SpecialInstructions { get; }
    }
}
