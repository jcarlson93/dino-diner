/* Dino Nuggets.cs
 * Author: Jake Carlson
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Dino Nuggets entree.
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem
    {
        /// <summary>
        /// Stores the amount of nuggets in the entree.
        /// </summary>
        private uint nuggetCount;

        /// <summary>
        /// List to store the ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Gets any special instructions for this menu item.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (nuggetCount > 6)
                {
                    special.Add($"{nuggetCount - 6} Extra Nuggets");
                }
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for the Dino Nuggets class. Sets the price and calories.
        /// </summary>
        public DinoNuggets()
        {
            this.nuggetCount = 6;
            this.Price = 4.25;
            this.Calories = nuggetCount * 59;
        }

        /// <summary>
        /// Method to add a nugget to the entree. Increases the price and calories
        /// for each nugget added.
        /// </summary>
        public void AddNugget()
        {
            nuggetCount++;
            Ingredients.Add("Chicken Nugget");
            Price += 0.25;
            Calories += 59;
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns>The name of the Menu Item.</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
