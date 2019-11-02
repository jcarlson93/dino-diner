/* Veloci-Wrap Customization page
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
    /// Interaction logic for VelociWrapCustomization.xaml
    /// </summary>
    public partial class VelociWrapCustomization : Page
    {
        // Private backing variables.
        private VelociWrap wrap;

        /// <summary>
        /// Constructor for the Veloci-Wrap Customization page.
        /// </summary>
        /// <param name="wrap">The Veloci-rap order item to be customized.</param>
        public VelociWrapCustomization(VelociWrap wrap)
        {
            InitializeComponent();
            this.wrap = wrap;
        }

        /// <summary>
        /// Click event for the Hold Lettuce button, holds the lettuce for the Veloci-Wrap order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            wrap.HoldLettuce();
        }

        /// <summary>
        /// Click event for the Hold Dressing button, holds the dressing for the Veloci-Wrap order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            wrap.HoldDressing();
        }

        /// <summary>
        /// Click event for the Hold Cheese button, holds the cheese for the Veloci-Wrap order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            wrap.HoldCheese();
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
