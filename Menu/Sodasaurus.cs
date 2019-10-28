/* Sodasaurus Class
 * Author: Jake Carlson
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Sodasaurus drink.
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem
    {
        /// <summary>
        /// Stores the flavor of the sodasaurus drink.
        /// </summary>
        private SodasaurusFlavor flavor = SodasaurusFlavor.Cola;

        /// <summary>
        /// Stores the size of the sodasaurus drink.
        /// </summary>
        private Size size;

        /// <summary>
        /// Gets and sets the flavor of the sodasaurus drink.
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        /// <summary>
        /// Gets and sets the price and calories based on the size of the drink.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                }
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Description");
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Stores the ingredients of the sodasaurus drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }

        /// <summary>
        /// Gets any special instructions for this order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for the Sodasaurus class.
        /// </summary>
        public Sodasaurus()
        {
            this.Size = Size.Small;
            this.Price = 1.50;
            this.Calories = 112;
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns>The name of the Menu Item.</returns>
        public override string ToString()
        {
            return $"{size} {Flavor} Sodasaurus";
        }
    }
}
