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
        private CretaceousCombo combo;

        /// <summary>
        /// The constructor for the Pterodactyl Wings Customization page.
        /// </summary>
        /// <param name="wings">The Pterodactyl Wings order item to be customized.</param>
        public PterodactylWingsCustomization(PterodactylWings wings)
        {
            InitializeComponent();
            this.wings = wings;
        }

        /// <summary>
        /// Overloaded constructor for the Pterodacyl Wings Customization page. Passes in the selected entree from the Combo Selection page.
        /// </summary>
        /// <param name="combo">The combo that was picked in the Combo Selection page.</param>
        public PterodactylWingsCustomization(CretaceousCombo combo)
        {
            InitializeComponent();
            this.wings = (PterodactylWings)combo.Entree;
            this.combo = combo;
        }

        /// <summary>
        /// Click event for the done button.
        /// If Pterodactyl Wings were selected as the entree from the Combo Selection page, navigate to the Cusomize Combo page.
        /// If Pterodactyl Wings were selected as the entree from the Entree Selection page, navigate back to the Entree Selection page.
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
