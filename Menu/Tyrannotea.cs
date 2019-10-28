/* Tyrannotea Class
 * Author: Jake Carlson
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Tyrannotea drink.
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem
    {
        /// <summary>
        /// Stores the size of the Tyrannotea drink.
        /// </summary>
        private Size size;

        /// <summary>
        /// Tells whether the tyrannotea is sweet or not.
        /// </summary>
        public bool Sweet { get; set; } = false;

        /// <summary>
        /// Tells whether the tyrannotea has lemon or not.
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
                        Price = 1.99;
                        Calories = 32;
                        if (Sweet)
                        {
                            Calories *= 2;
                        }
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        if (Sweet)
                        {
                            Calories *= 2;
                        }
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 8;
                        if (Sweet)
                        {
                            Calories *= 2;
                        }
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Stores the ingredients of the tyrannotea.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (Sweet) ingredients.Add("Cane Sugar");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets any special instructions for this order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for the tyrannotea drink.
        /// </summary>
        public Tyrannotea()
        {
            this.Size = Size.Small;
            this.Price = 0.99;
            this.Calories = 8;
        }

        /// <summary>
        /// Adds the lemon to tyrannotea drink.
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns>The name of the Menu Item.</returns>
        public override string ToString()
        {
            if (Sweet)
            {
                return $"{size} Sweet Tyrannotea";
            }
            else
            {
                return $"{size} Tyrannotea";
            }
        }
    }
}
