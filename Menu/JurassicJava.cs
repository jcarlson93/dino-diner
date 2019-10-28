/* Jurassic Java Class
 * Author: Jake Carlson
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Jurassic Java drink.
    /// </summary>
    public class JurassicJava : Drink, IMenuItem
    {
        // Holds the size of the Jurassic Java drink.
        private Size size;

        /// <summary>
        /// Property for specifying if room for cream is needed.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Property for specifying if the Jurassic Java is decaf.
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
                return new List<string>() { "Water", "Coffee" };
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
                if (Ice) special.Add("Add Ice");
                if (RoomForCream) special.Add("Leave Room For Cream");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for the Jurassic Java drink.
        /// </summary>
        public JurassicJava()
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
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method for adding ice.
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns>The name of the Menu Item.</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return $"{size} Decaf Jurassic Java";
            }
            else
            {
                return $"{size} Jurassic Java";
            }
        }
    }
}
