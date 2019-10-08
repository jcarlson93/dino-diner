﻿/* Brontowurst.cs
 * Author: Jake Carlson
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent the Brontowurst entree.
    /// </summary>
    public class Brontowurst : Entree, IMenuItem
    {
        // Tells if the ingredients are on the Brontowurst.
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// List to store the ingredients.
        /// </summary>
        public override List<string> Ingredients
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

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns>The name of the Menu Item.</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
