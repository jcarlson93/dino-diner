/* TRexKingBurger.cs
 * Author: Jake Carlson
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent the T-Rex King Burger entree.
    /// </summary>
    public class TRexKingBurger
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
        /// Property that gets and sets the price of the T-Rex King Burger.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Property that gets and sets the calories of the T-Rex King Burger.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// List to store the ingredients.
        /// </summary>
        public List<string> Ingredients
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
        }

        /// <summary>
        /// Method to hold the lettuce for the burger.
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }

        /// <summary>
        /// Method to hold the tomato for the burger.
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
        }

        /// <summary>
        /// Method to hold the onion for the burger.
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
        }

        /// <summary>
        /// Method to hold the pickle for the burger.
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
        }

        /// <summary>
        /// Method to hold the ketchup for the burger.
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
        }

        /// <summary>
        /// Method to hold the mustard for the burger.
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
        }

        /// <summary>
        /// Method to hold the mayo for the burger.
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
        }
    }
}
