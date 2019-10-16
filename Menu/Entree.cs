/* Entree base Class
 * Author: Jake Carlson
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class that represents the Entrees.
    /// </summary>
    public abstract class Entree : IMenuItem
    {
        /// <summary>
        /// Gets and sets the Price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the Calories.
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
    }
}
