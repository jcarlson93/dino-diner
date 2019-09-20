using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Abstract class that represents the Entrees.
    /// </summary>
    public abstract class Entree
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
    }
}
