/* Dino Nuggets.cs
 * Author: Jake Carlson
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Represents the Dino Nuggets entree.
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// Property that gets and sets the price.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Property that gets and sets the calories.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// List to store the ingredients.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < 6; i++)
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
            this.Price = 4.25;
            this.Calories = 6 * 59;
        }

        /// <summary>
        /// Method to add a nugget to the entree. Increases the price and calories
        /// for each nugget added.
        /// </summary>
        public void AddNugget()
        {
            Ingredients.Add("Chicken Nugget");
            Price += 0.25;
            Calories += 59;
        }
    }
}
