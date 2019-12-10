/* Website Menu Page
 * Author: Jake Carlson
*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        // Private access variables
        private Menu _menu = new Menu();
        private IEnumerable<IMenuItem> combos;
        private IEnumerable<IMenuItem> entrees;
        private IEnumerable<IMenuItem> sides;
        private IEnumerable<IMenuItem> drinks;

        /// <summary>
        /// Property to get and set the list of all the available combos in the Dino-Diner Menu.
        /// </summary>
        public IEnumerable<IMenuItem> AvailableCombos
        {
            get
            {
                return combos;
            }
            protected set
            {
                combos = value;
            }
        }

        /// <summary>
        /// Property to get and set the list of all the available entrees in the Dino-Diner Menu.
        /// </summary>
        public IEnumerable<IMenuItem> AvailableEntrees
        {
            get
            {
                return entrees;
            }
            protected set
            {
                entrees = value;
            }
        }

        /// <summary>
        /// Property to get and set the list of all the available sides in the Dino-Diner Menu.
        /// </summary>
        public IEnumerable<IMenuItem> AvailableSides
        {
            get
            {
                return sides;
            }
            protected set
            {
                sides = value;
            }
        }

        /// <summary>
        /// Property to get and set the list of all the available drinks in the Dino-Diner Menu.
        /// </summary>
        public IEnumerable<IMenuItem> AvailableDrinks
        {
            get
            {
                return drinks;
            }
            protected set
            {
                drinks = value;
            }
        }

        /// <summary>
        /// Property to hold the string entered into the search bar.
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// Property to hold the list of menu category filters selected.
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        /// <summary>
        /// Property to hold the minimum price to filter by.
        /// </summary>
        [BindProperty]
        public double? minimumPrice { get; set; }

        /// <summary>
        /// Property to hold the maximum price to filter by.
        /// </summary>
        [BindProperty]
        public double? maximumPrice { get; set; }

        /// <summary>
        /// Property to hold the list of possible ingredient filters selected.
        /// </summary>
        [BindProperty]
        public List<string> possibleIngredients { get; set; } = new List<string>();

        /// <summary>
        /// Property to get the menu.
        /// </summary>
        public Menu Menu
        {
            get
            {
                return _menu;
            }
        }

        /// <summary>
        /// Initializes the page, displays the default content of the Menu page.
        /// </summary>
        public void OnGet()
        {
            AvailableCombos = Menu.AvailableCombos;
            AvailableEntrees = Menu.AvailableEntrees;
            AvailableSides = Menu.AvailableSides;
            AvailableDrinks = Menu.AvailableDrinks;
        }

        /// <summary>
        /// Handles form submissions, displays the page content after searching and filtering is applied.
        /// </summary>
        public void OnPost()
        {
            AvailableCombos = Menu.AvailableCombos;
            AvailableEntrees = Menu.AvailableEntrees;
            AvailableSides = Menu.AvailableSides;
            AvailableDrinks = Menu.AvailableDrinks;

            if (search != null)
            {
                AvailableCombos = AvailableCombos.Where(item => item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                AvailableEntrees = AvailableEntrees.Where(item => item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                AvailableSides = AvailableSides.Where(item => item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                AvailableDrinks = AvailableDrinks.Where(item => item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            if (minimumPrice != null && minimumPrice < maximumPrice)
            {
                AvailableCombos = AvailableCombos.Where(item => item.Price >= minimumPrice);
                AvailableEntrees = AvailableEntrees.Where(item => item.Price >= minimumPrice);
                AvailableSides = AvailableSides.Where(item => item.Price >= minimumPrice);
                AvailableDrinks = AvailableDrinks.Where(item => item.Price >= minimumPrice);
            }

            if (maximumPrice != null && maximumPrice > minimumPrice)
            {
                AvailableCombos = AvailableCombos.Where(item => item.Price <= maximumPrice);
                AvailableEntrees = AvailableEntrees.Where(item => item.Price <= maximumPrice);
                AvailableSides = AvailableSides.Where(item => item.Price <= maximumPrice);
                AvailableDrinks = AvailableDrinks.Where(item => item.Price <= maximumPrice);
            }

            if (possibleIngredients.Count > 0)
            {
                foreach (string i in possibleIngredients)
                {
                    AvailableCombos = AvailableCombos.Where(item => !item.Ingredients.Contains(i));
                    AvailableEntrees = AvailableEntrees.Where(item => !item.Ingredients.Contains(i));
                    AvailableSides = AvailableSides.Where(item => !item.Ingredients.Contains(i));
                    AvailableDrinks = AvailableDrinks.Where(item => !item.Ingredients.Contains(i));
                }
            }
        }

        /// <summary>
        /// Compares the menu items to the search property and filters out menu items that
        /// do not contain what is entered into the search bar.
        /// </summary>
        /// <param name="items">The list of menu items to filter.</param>
        /// <returns>The list of filtered menu items.</returns>
        public List<IMenuItem> Search(List<IMenuItem> items)
        {
            List<IMenuItem> filtered = new List<IMenuItem>();

            foreach (IMenuItem item in items)
            {
                if (item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    filtered.Add(item);
                }
            }
            return filtered;
        }

        /// <summary>
        /// Compares the menu items price property to the minimumPrice property.
        /// If the items price is greater than the minimum price property, it is 
        /// added to the list of filtered items.
        /// </summary>
        /// <param name="items">The list of menu items to filter.</param>
        /// <returns>The list of filtered menu items.</returns>
        public List<IMenuItem> FilterByMinPrice(List<IMenuItem> items)
        {
            List<IMenuItem> filtered = new List<IMenuItem>();
            
            foreach (IMenuItem item in items)
            {
                if (item.Price >= minimumPrice)
                {
                    filtered.Add(item);
                }
            }
            return filtered;
        }

        /// <summary>
        /// Compares the menu items price property to the maximumPrice Property.
        /// If the items price is less than the maximum price property, it is
        /// added to the list of filtered items.
        /// </summary>
        /// <param name="items">The list of menu items to filter.</param>
        /// <returns>The list of filtered menu items.</returns>
        public List<IMenuItem> FilterByMaxPrice(List<IMenuItem> items)
        {
            List<IMenuItem> filtered = new List<IMenuItem>();

            foreach (IMenuItem item in items)
            {
                if (item.Price <= maximumPrice)
                {
                    filtered.Add(item);
                }
            }
            return filtered;
        }

        /// <summary>
        /// Compares the menu items ingredients property to the possibleIngredients property.
        /// If the item does not contain an ingredient that has been checked in the Exclude 
        /// Ingredients filter section, the item is added to the list of filtered items.
        /// </summary>
        /// <param name="items">The list of menu items to filter by.</param>
        /// <returns>The list of filtered menu items.</returns>
        public List<IMenuItem> FilterByIngredients(List<IMenuItem> items)
        {
            List<IMenuItem> filtered = new List<IMenuItem>();

            foreach (IMenuItem item in items)
            {
                foreach (string i in possibleIngredients)
                {
                    if (!item.Ingredients.Contains(i))
                    {
                        filtered.Add(item);
                    }
                }
            }
            return filtered;
        }
    }
}