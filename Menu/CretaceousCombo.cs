/* Cretaceous Combo class
 * Author: Jake Carlson
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem
    {
        // Backing Variables
        private Size size;
        private Entree entree;
        private Side side;
        private Drink drink;

        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                this.entree = value;
                Entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChange("Description");
                    NotifyOfPropertyChange("Size");
                    NotifyOfPropertyChange("Price");
                    NotifyOfPropertyChange("Calories");
                    NotifyOfPropertyChange("Special");
                    NotifyOfPropertyChange("Ingredients");
                };
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Ingredients");
            }
        }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                this.side = value;
                Side.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChange("Description");
                    NotifyOfPropertyChange("Size");
                    NotifyOfPropertyChange("Price");
                    NotifyOfPropertyChange("Calories");
                    NotifyOfPropertyChange("Special");
                    NotifyOfPropertyChange("Ingredients");
                };
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Ingredients");
            }
        }

        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                this.drink = value;
                Drink.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChange("Description");
                    NotifyOfPropertyChange("Size");
                    NotifyOfPropertyChange("Price");
                    NotifyOfPropertyChange("Calories");
                    NotifyOfPropertyChange("Special");
                    NotifyOfPropertyChange("Ingredients");
                };
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Ingredients");
            }
        }

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Ingredients");
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

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
        /// Gets a description of this menu item.
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets any special instructions for this menu item.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Special);
                ingredients.Add(Side.ToString()); // could also do Side.Description.
                ingredients.AddRange(Side.Special);
                ingredients.Add(Drink.ToString());
                ingredients.AddRange(Drink.Special);
                return ingredients.ToArray();
            }
        }

        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns>The name of the Menu Item.</returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }
    }
}
