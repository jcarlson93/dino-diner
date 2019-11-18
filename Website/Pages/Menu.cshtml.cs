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

        }
    }
}