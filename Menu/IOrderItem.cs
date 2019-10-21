/* Interface for the Order Item class.
 * Author: Jake Carlson
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Order Item interface.
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Gets the Price for the Order Item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets a description of the Order Item.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets any special instructions for the order item.
        /// </summary>
        string[] Special { get; }

    }
}
