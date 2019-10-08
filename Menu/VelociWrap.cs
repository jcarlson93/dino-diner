/* VelociWrap.cs
 * Author: Jake Carlson
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Veloci-Wrap entree.
    /// </summary>
    public class VelociWrap : Entree, IMenuItem
    {
        // Tells whether or not the ingredients are on the wrap.
        private bool lettuce = true;
        private bool dressing = true;
        private bool cheese = true;

        /// <summary>
        /// List to store the ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla" };
                ingredients.Add("Chicken Breast");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the Veloci-Wrap class. Sets the price and calories.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Method to hold the dressing.
        /// </summary>
        public void HoldDressing()
        {
            dressing = false;
        }

        /// <summary>
        /// Method to hold the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }

        /// <summary>
        /// Method to hold the cheese.
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
        }
    }
}
