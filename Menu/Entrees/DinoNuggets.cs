/* Dino Nuggets.cs
 * Author: Jake Carlson
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

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

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 6 * 59;
        }

        public void AddNugget()
        {
            Ingredients.Add("Chicken Nugget");
            Price += 0.25;
            Calories += 59;
        }
    }
}
