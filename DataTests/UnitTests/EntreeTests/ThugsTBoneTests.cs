﻿/*
 * Author: Zachery Brunner
 * Edited by: John Wills
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldImplementIOInterface()    //M3
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(tb);
        }

        [Fact]
        public void ShouldBeAnEntree() //M3
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tb);
        }

        [Fact]
        public void ShouldReturnCorrectPrice() //AGH
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.NotEqual(0, tb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories() //AGH
        {
            ThugsTBone tb = new ThugsTBone();
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Empty(tb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tb.ToString());
        }
    }
}