/* T-Rex King Burger Customization page
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
    /// Interaction logic for TRexKingBurgerCustomization.xaml
    /// </summary>
    public partial class TRexKingBurgerCustomization : Page
    {
        // Private backing variables.
        private TRexKingBurger burger;

        /// <summary>
        /// Constructor for the T-Rex King Burger Customization page.
        /// </summary>
        /// <param name="burger">The T-Rex King Burger order item to be customized.</param>
        public TRexKingBurgerCustomization(TRexKingBurger burger)
        {
            InitializeComponent();
            this.burger = burger;
        }

        /// <summary>
        /// Click event for the Hold Bun button, Holds the bun for the T-Rex King Burger order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            burger.HoldBun();
        }

        /// <summary>
        /// Click event for the Hold Lettuce button, holds the lettuce for the T-Rex King Burger order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            burger.HoldLettuce();
        }

        /// <summary>
        /// Click event for the Hold Tomato button, holds the tomato for the T-Rex King Burger order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            burger.HoldTomato();
        }

        /// <summary>
        /// Click event for the Hold Onion button, holds the onion for the T-Rex King Burger order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            burger.HoldOnion();
        }

        /// <summary>
        /// Click event for the Hold Pickles button, holds the pickles for the T-Rex King Burger order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickles(object sender, RoutedEventArgs args)
        {
            burger.HoldPickle();
        }

        /// <summary>
        /// Click event for the Hold Ketchup button, holds the ketchup for the T-Rex King Burger order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            burger.HoldKetchup();
        }

        /// <summary>
        /// Click event for the Hold Mustard button, holds the mustard for the T-Rex King Burger order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            burger.HoldMustard();
        }

        /// <summary>
        /// Click event for the Hold Mayo button, holds the mayo for the T-Rex King Burger order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            burger.HoldMayo();
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
