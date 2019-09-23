using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    class Sodasaurus : Drink
    {
        /// <summary>
        /// Stores the size of the sodasaurus drink.
        /// </summary>
        private Size size;

        public SodaSaurusFlavor Flavor { get; set; }

        /// <summary>
        /// Gets and sets the price and calories based on the size of the side.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        public Sodasaurus()
        {

        }
    }
}
