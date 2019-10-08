using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Mezzorella Sticks side.
    /// </summary>
    public class MezzorellaSticks : Side, IMenuItem
    {
        /// <summary>
        /// Stores the sizes of the sides.
        /// </summary>
        private Size size;

        /// <summary>
        /// Gets and sets the price and calories based on the size of the side.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Constructor for the Mezzorella Sticks side.
        /// </summary>
        public MezzorellaSticks()
        {
            this.Price = 0.99;
            this.Calories = 540;
            this.Ingredients = new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
        }
    }
}
