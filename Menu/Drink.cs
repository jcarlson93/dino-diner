/* Drink base Class
 * Author: Jake Carlson
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class representing the drinks.
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Tells whether the drink has ice or not.
        /// </summary>
        public bool Ice { get; protected set; } = true;

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredient list.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Method to hold the ice for a drink.
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false; 
        }
    }
}
