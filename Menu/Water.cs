/* Water Class
 * Author: Jake Carlson
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the water drink.
    /// </summary>
    public class Water : Drink, IMenuItem
    {
        // Stores the size of the water.
        private Size size;

        /// <summary>
        /// Determines if there is lemon in the water.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Gets and sets the price and calories based on the size of the drink.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Small:
                        Price = 0.10;
                        Calories = 0;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Stores the ingredients of the sodasaurus drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the Water class.
        /// </summary>
        public Water()
        {
            this.size = Size.Small;
            this.Price = 0.10;
            this.Calories = 0;
        }

        /// <summary>
        /// Method to add lemon to the water.
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }
    }
}
