/* Dino Nuggets.cs
 * Author: Jake Carlson
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Dino Nuggets entree.
    /// </summary>
    public class DinoNuggets : Entree
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
    }
}
