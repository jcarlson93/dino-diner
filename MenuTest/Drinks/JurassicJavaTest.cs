/* Jurassic Java Test Class
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
    /// Tests for the Jurassic Java Class.
    /// </summary>
    public class JurassicJavaTest
    {
        /// <summary>
        /// Checks for the correct default price.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(0.59, java.Price);
        }

        /// <summary>
        /// Checks for the correct default calories.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(2, java.Calories);
        }

        /// <summary>
        /// Checks if the drink has the ice property set to true.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        /// <summary>
        /// Checks for the correct default size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldHaveCorrectRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }

        /// <summary>
        /// Checks the price after changing to a small size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal(0.59, java.Price);
        }

        /// <summary>
        /// Checks the calories after changing to a small size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        /// <summary>
        /// Checks the price after changing to a medium size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            java.Size = Size.Medium;
            Assert.Equal(0.99, java.Price);
        }

        /// <summary>
        /// Checks the calories after changing to a medium size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        /// <summary>
        /// Checks the price after changing to a large size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Large;
            Assert.Equal(1.49, java.Price);
        }

        /// <summary>
        /// Checks the calories after changing to a large size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        /// <summary>
        /// Checks the Ice property after invoking the AddIce() method.
        /// </summary>
        [Fact]
        public void AddTheIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        /// <summary>
        /// Checks the RoomForCream property after invoking the LeaveRoomForCream() method.
        /// </summary>
        [Fact]
        public void LeaveRoomForTheCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        /// <summary>
        /// Tests if the Jurassic Java drink has the correct ingredients.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }
    }
}
