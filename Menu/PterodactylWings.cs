/* PterodactylWings Class
 * Author: Jake Carlson
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Pterodactyl Wings entree.
    /// </summary>
    public class PterodactylWings : Entree, IMenuItem
    {
        /// <summary>
        /// List to store the ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                ingredients.Add("Wing Sauce");
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
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for the Pterodactyl Wings class. Sets the price and calories.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns>The name of the Menu Item.</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
