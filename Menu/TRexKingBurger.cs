﻿/* T-Rex King Burger Class
 * Author: Jake Carlson
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent the T-Rex King Burger entree.
    /// </summary>
    public class TRexKingBurger : Entree, IMenuItem
    {
        // Tells if the ingredients are on the burger.
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        /// <summary>
        /// List to store the ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
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
                if (!bun) special.Add("Hold Bun");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                if (!onion) special.Add("Hold Onion");
                if (!pickle) special.Add("Hold Pickles");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for the T-Rex King Burger class. Sets the price and calories.
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Method to hold the bun for the burger.
        /// </summary>
        public void HoldBun()
        {
            bun = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to hold the lettuce for the burger.
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to hold the tomato for the burger.
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to hold the onion for the burger.
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to hold the pickle for the burger.
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to hold the ketchup for the burger.
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to hold the mustard for the burger.
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to hold the mayo for the burger.
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns>The name of the Menu Item.</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
