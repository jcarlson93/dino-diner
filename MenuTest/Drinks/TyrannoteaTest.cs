using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;


namespace MenuTest.Drinks
{
    /// <summary>
    /// Tests for the Tyrannotea class.
    /// </summary>
    public class TyrannoteaTest
    {
        /// <summary>
        /// Checks for the correct default price of the tyrannotea.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(0.99, tea.Price);
        }

        /// <summary>
        /// Checks for the correct default calories of the tyrannotea.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Checks for the correct default size of the tyrannotea.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(Size.Small, tea.Size);
        }

        /// <summary>
        /// Checks for the correct default ice property.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        /// <summary>
        /// Checks for the correct default lemon property.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }

        /// <summary>
        /// Checks for the correct default sweet property.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSweetener()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }

        /// <summary>
        /// Checks the price after changing to a small size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal(0.99, tea.Price);
        }

        /// <summary>
        /// Checks the calories after changing to a small size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Checks the price after changing to a medium size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Size = Size.Medium;
            Assert.Equal(1.49, tea.Price);
        }

        /// <summary>
        /// Checks the calories after changing to a medium size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// Checks the price after changing to a large size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Large;
            Assert.Equal(1.99, tea.Price);
        }

        /// <summary>
        /// Checks the calories after changing to a large size.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        /// <summary>
        /// Checks the Ice property after invoking the HoldIce() function.
        /// </summary>
        [Fact]
        public void HoldTheIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        /// <summary>
        /// Checks the Lemon property after invoking the AddLemon() function.
        /// </summary>
        [Fact]
        public void AddTheLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        /// <summary>
        /// Checks for the correct calories after adding sweetener to a small size.
        /// </summary>
        [Fact]
        public void CorrectSweetCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Small;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// Checks for the correct calories after adding sweetener to a medium size.
        /// </summary>
        [Fact]
        public void CorrectSweetCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
        }

        /// <summary>
        /// Checks for the correct calories after adding sweetener to a large size.
        /// </summary>
        [Fact]
        public void CorrectSweetCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }

        /// <summary>
        /// Checks for the correct calories after adding and then removing sweetener from a small size.
        /// </summary>
        [Fact]
        public void CorrectSweetCaloriesForSmallAfterRemoving()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Checks for the correct calories after adding and then removing sweetener from a medium size.
        /// </summary>
        [Fact]
        public void CorrectSweetCaloriesForMediumAfterRemoving()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// Checks for the correct calories after adding and then removing sweetener from a large size.
        /// </summary>
        [Fact]
        public void CorrectSweetCaloriesForLargeAfterRemoving()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(32, tea.Calories);
        }

        /// <summary>
        /// Tests if the Tyrannotea drink has the correct ingredients.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
        }
    }
}
