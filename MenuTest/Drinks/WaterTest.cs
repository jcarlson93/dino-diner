/* Water Test Class
 * Author: Jake Carlson
*/

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Tests for the Water class.
    /// </summary>
    public class WaterTest
    {
        /// <summary>
        /// Checks for the correct default price of the Water.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water wt = new Water();
            Assert.Equal(0.10, wt.Price);
        }

        /// <summary>
        /// Checks for the correct default calories of the Water.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water wt = new Water();
            Assert.Equal<uint>(0, wt.Calories);
        }

        /// <summary>
        /// Checks for the correct default size of the Water.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water wt = new Water();
            Assert.Equal(Size.Small, wt.Size);
        }

        /// <summary>
        /// Checks for the correct default ice property.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water wt = new Water();
            Assert.True(wt.Ice);
        }

        /// <summary>
        /// Checks for the correct default lemon property.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Water wt = new Water();
            Assert.False(wt.Lemon);
        }

        /// <summary>
        /// Checks the price after changing to a small size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Water wt = new Water();
            wt.Size = Size.Medium;
            wt.Size = Size.Small;
            Assert.Equal(0.10, wt.Price);
        }

        /// <summary>
        /// Checks the calories after changing to a small size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Water wt = new Water();
            wt.Size = Size.Medium;
            wt.Size = Size.Small;
            Assert.Equal<uint>(0, wt.Calories);
        }

        /// <summary>
        /// Checks the price after changing to a medium size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Water wt = new Water();
            wt.Size = Size.Large;
            wt.Size = Size.Medium;
            Assert.Equal(0.10, wt.Price);
        }

        /// <summary>
        /// Checks the calories after changing to a medium size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Water wt = new Water();
            wt.Size = Size.Large;
            wt.Size = Size.Medium;
            Assert.Equal<uint>(0, wt.Calories);
        }

        /// <summary>
        /// Checks the price after changing to a large size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Water wt = new Water();
            wt.Size = Size.Medium;
            wt.Size = Size.Large;
            Assert.Equal(0.10, wt.Price);
        }

        /// <summary>
        /// Checks the calories after changing to a large size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Water wt = new Water();
            wt.Size = Size.Medium;
            wt.Size = Size.Large;
            Assert.Equal<uint>(0, wt.Calories);
        }

        /// <summary>
        /// Checks the Ice property after invoking the HoldIce() method.
        /// </summary>
        [Fact]
        public void HoldTheIce()
        {
            Water wt = new Water();
            wt.HoldIce();
            Assert.False(wt.Ice);
        }

        /// <summary>
        /// Checks the Lemon property after invoking the AddLemon() method.
        /// </summary>
        [Fact]
        public void AddTheLemon()
        {
            Water wt = new Water();
            wt.AddLemon();
            Assert.True(wt.Lemon);
        }

        /// <summary>
        /// Tests if the Water drink has the correct ingredients.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water wt = new Water();
            Assert.Contains<string>("Water", wt.Ingredients);
            Assert.Single(wt.Ingredients);
        }
    }
}
