/* Menu Item Interface
 * Author: Jake Carlson
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The Interface for a menu item.
    /// </summary>
    public interface IMenuItem 
    {
        /// <summary>
        /// Property for the price of the menu item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Property for the calories of the menu item.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// A list of the ingredients of the menu item.
        /// </summary>
        List<string> Ingredients { get; }
    }
}
