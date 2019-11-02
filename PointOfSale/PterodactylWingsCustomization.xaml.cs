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
    /// Interaction logic for PterodactylWings.xaml
    /// </summary>
    public partial class PterodactylWingsCustomization : Page
    {
        // Private backing variables.
        private PterodactylWings wings;

        /// <summary>
        /// The constructor for the Pterodactyl Wings Customization page.
        /// </summary>
        /// <param name="wings"></param>
        public PterodactylWingsCustomization(PterodactylWings wings)
        {
            InitializeComponent();
            this.wings = wings;
        }

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
