/* SteakosaurusBurger.cs
 * Author: Jake Carlson
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        public void HoldBun()
        {
            bun = false;
        }

        public void HoldPickle()
        {
            pickle = false;
        }

        public void HoldKetchup()
        {
            ketchup = false;
        }

        public void HoldMustard()
        {
            mustard = false;
        }
    }
}
