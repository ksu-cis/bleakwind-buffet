/*
 * Author: Zachery Brunner
 * Edited by: John Wills
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldImplementIOInterface()    //M3
        {
            GardenOrcOmelette goc = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(goc);
        }

        [Fact]
        public void ShouldBeAnEntree() //M3
        {
            GardenOrcOmelette goc = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(goc);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette goc = new GardenOrcOmelette();
            Assert.True(goc.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette goc = new GardenOrcOmelette();
            Assert.True(goc.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette goc = new GardenOrcOmelette();
            Assert.True(goc.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette goc = new GardenOrcOmelette();
            Assert.True(goc.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette goc = new GardenOrcOmelette();
            goc.Broccoli = true;
            Assert.True(goc.Broccoli);
            goc.Broccoli = false;
            Assert.False(goc.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette goc = new GardenOrcOmelette();
            goc.Mushrooms = true;
            Assert.True(goc.Mushrooms);
            goc.Mushrooms = false;
            Assert.False(goc.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette goc = new GardenOrcOmelette();
            goc.Tomato = true;
            Assert.True(goc.Tomato);
            goc.Tomato = false;
            Assert.False(goc.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette goc = new GardenOrcOmelette();
            goc.Cheddar = true;
            Assert.True(goc.Cheddar);
            goc.Cheddar = false;
            Assert.False(goc.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice() //AGH
        {
            GardenOrcOmelette goc = new GardenOrcOmelette();
            Assert.NotEqual(0, goc.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories() // AGH
        {
            GardenOrcOmelette goc = new GardenOrcOmelette();
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette goc = new GardenOrcOmelette();
            goc.Broccoli = includeBroccoli;
            goc.Mushrooms = includeMushrooms;
            goc.Tomato = includeTomato;
            goc.Cheddar = includeCheddar;
            if(includeBroccoli&&includeCheddar&&includeMushrooms&&includeTomato)
            {
                Assert.Empty(goc.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Broccoli" + "Hold Mushrooms" + "Hold Tomato" + "Hold Cheddar", goc.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette goc = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goc.ToString());
        }
    }
}