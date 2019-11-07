/* VelociWrap Class
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
        /// Gets any special instructions for this menu item.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!lettuce) special.Add("Hold Lettuce");
                if (!dressing) special.Add("Hold Dressing");
                if (!cheese) special.Add("Hold Cheese");
                return special.ToArray();
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
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to hold the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to hold the cheese.
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns>The name of the Menu Item.</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
