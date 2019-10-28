/* Drink base Class
 * Author: Jake Carlson
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class representing the drinks.
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem
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
        /// The PropertyChanged event handler; notifies of changes to the Price, Description, and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper function for notifying of property changes.
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets a description of this order item.
        /// </summary>
        public virtual string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets any special instructions for this order item
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Method to hold the ice for a drink.
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
            NotifyOfPropertyChange("Special");
        }
    }
}
