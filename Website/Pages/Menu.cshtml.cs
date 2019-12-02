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
        private List<IMenuItem> combos = new List<IMenuItem>();
        private List<IMenuItem> entrees = new List<IMenuItem>();
        private List<IMenuItem> sides = new List<IMenuItem>();
        private List<IMenuItem> drinks = new List<IMenuItem>();

        public List<IMenuItem> AvailableCombos
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

        public List<IMenuItem> AvailableEntrees
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

        public List<IMenuItem> AvailableSides
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

        public List<IMenuItem> AvailableDrinks
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

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public double? minimumPrice { get; set; }

        [BindProperty]
        public double? maximumPrice { get; set; }

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

        public void OnGet()
        {
            AvailableCombos = Menu.AvailableCombos;
            AvailableEntrees = Menu.AvailableEntrees;
            AvailableSides = Menu.AvailableSides;
            AvailableDrinks = Menu.AvailableDrinks;
        }

        public void OnPost()
        {
            AvailableCombos = Menu.AvailableCombos;
            AvailableEntrees = Menu.AvailableEntrees;
            AvailableSides = Menu.AvailableSides;
            AvailableDrinks = Menu.AvailableDrinks;

            if (minimumPrice != null && minimumPrice < maximumPrice)
            {
                AvailableCombos = FilterByMinPrice(AvailableCombos);
                AvailableEntrees = FilterByMinPrice(AvailableEntrees);
                AvailableSides = FilterByMinPrice(AvailableSides);
                AvailableDrinks = FilterByMinPrice(AvailableDrinks);
            }

            if (maximumPrice != null && maximumPrice > minimumPrice)
            {
                AvailableCombos = FilterByMaxPrice(AvailableCombos);
                AvailableEntrees = FilterByMaxPrice(AvailableEntrees);
                AvailableSides = FilterByMaxPrice(AvailableSides);
                AvailableDrinks = FilterByMaxPrice(AvailableDrinks);
            }
        }

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
    }
}