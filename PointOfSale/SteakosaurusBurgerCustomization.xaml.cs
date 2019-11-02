/* Steakosaurus Burger Customization page
 * Authpr: Jake Carlson
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SteakosaurusBurgerCustomization.xaml
    /// </summary>
    public partial class SteakosaurusBurgerCustomization : Page
    {
        // Private backing variables.
        private SteakosaurusBurger burger;

        /// <summary>
        /// Constructor for the Steakosaurus Burger Customization page.
        /// </summary>
        /// <param name="burger">The Steakosaurus Burger order item to be customized.</param>
        public SteakosaurusBurgerCustomization(SteakosaurusBurger burger)
        {
            InitializeComponent();
            this.burger = burger;
        }

        /// <summary>
        /// Click event for the Hold Bun button, Holds the bun for the Steakosaurus Burger order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            burger.HoldBun();
        }

        /// <summary>
        /// Click event for the Hold Pickles button, Holds the pickles for the Steakosaurus Burger order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickles(object sender, RoutedEventArgs args)
        {
            burger.HoldPickle();
        }

        /// <summary>
        /// Click event for the Hold Ketchup button, Holds the ketchup for the Steakosaurus Burger order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            burger.HoldKetchup();
        }

        /// <summary>
        /// Click event for the Hold Mustard button, Holds the mustard for the Steakosaurus Burger order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            burger.HoldMustard();
        }

        /// <summary>
        /// Click event for the Done button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
