/* Brontowurst.cs
 * Author: Jake Carlson
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent the Brontowurst entree.
    /// </summary>
    public class Brontowurst
    {
        // Tells if the ingredients are on the Brontowurst.
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// Property that gets and sets the price of the brontowurst.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Property that gets and sets the calories of the brontowurst.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// List to store the ingredients.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the Brontowurst class. Sets the price and calories.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Method to hold the bun.
        /// </summary>
        public void HoldBun()
        {
            bun = false;
        }

        /// <summary>
        /// Method to hold the peppers.
        /// </summary>
        public void HoldPeppers()
        {
            peppers = false;
        }

        /// <summary>
        /// Method to hold the onion.
        /// </summary>
        public void HoldOnion()
        {
            onions = false;
        }
    }
}
