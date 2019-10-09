using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Triceritots side.
    /// </summary>
    public class Triceritots : Side, IMenuItem
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
                        Calories = 590;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Stores the ingredients of the Triceritots side.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// Constructor for the Triceritots side.
        /// </summary>
        public Triceritots()
        {
            this.Price = 0.99;
            this.Calories = 352;
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns>The name of the Menu Item.</returns>
        public override string ToString()
        {
            return $"{size} Triceritots";
        }
    }
}
