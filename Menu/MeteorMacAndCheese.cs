﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Meteor Mac and Cheese side.
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// Stores the sizes of the sides.
        /// </summary>
        private Size size;

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
                        Calories = 520;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Constructor for the Meteor Mac and Cheese side.
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Price = 0.99;
            this.Calories = 420;
            this.Ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
        }
    }
}