/* Jurrasic Java Class
 * Author: Jake Carlson
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Represents the Jurrasic Java drink.
    /// </summary>
    public class JurrasicJava : Drink
    {
        // Holds the size of the Jurrasic Java drink.
        private Size size;

        /// <summary>
        /// Property for specifying if room for cream is needed.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Property for specifying if the Jurrasic Java is decaf.
        /// </summary>
        public bool Decaf { get; set; } = false;

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
                        Price = 1.49;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Small:
                        Price = 0.59;
                        Calories = 2;
                        break;
                }
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
                return new List<string>() { "Water", "Coffee" };
            }
        }

        /// <summary>
        /// Constructor for the Jurrasic Java drink.
        /// </summary>
        public JurrasicJava()
        {
            this.size = Size.Small;
            this.Price = 0.59;
            this.Calories = 2;
            this.Ice = false;
        }

        /// <summary>
        /// Method for leaving room for cream.
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }

        /// <summary>
        /// Method for adding ice.
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }
    }
}
