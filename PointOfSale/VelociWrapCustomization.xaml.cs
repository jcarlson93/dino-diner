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
        private CretaceousCombo combo;

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
        /// Overloaded constructor for the Veloci-Wrap Customization page. Passes in the selected entree from the Combo Selection page.
        /// </summary>
        /// <param name="combo">The combo that was picked in the Combo Selection page.</param>
        public VelociWrapCustomization(CretaceousCombo combo)
        {
            InitializeComponent();
            this.wrap = (VelociWrap)combo.Entree;
            this.combo = combo;
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
        /// Click event for the done button.
        /// If Veloci-Wrap was selected as the entree from the Combo Selection page, navigate to the Cusomize Combo page.
        /// If Veloci-Wrap was selected as the entree from the Entree Selection page, navigate back to the Entree Selection page.
        /// If it cannot go back to the last page, navigate back to the Menu Category Selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else if (NavigationService.CanGoBack)
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
