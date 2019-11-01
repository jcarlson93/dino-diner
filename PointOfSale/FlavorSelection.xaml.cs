/* Flavor Selection Page
 * Author: Jake Carlson
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        // Private backing variables.
        private SodasaurusFlavor flavor;
        private Sodasaurus soda;

        /// <summary>
        /// Gets and sets the Sodasaurus drink.
        /// </summary>
        public Sodasaurus Soda
        {
            get
            {
                return soda;
            }
        }

        /// <summary>
        /// Gets and sets the Sodasaurus flavor.
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        /// <summary>
        /// Constructor for the Flavor Selection class.
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded constructor for the Flavor Selection class. 
        /// </summary>
        /// <param name="soda"></param>
        public FlavorSelection(Sodasaurus sodas)
        {
            InitializeComponent();
            soda = sodas;
        }

        /// <summary>
        /// Helper function for to set the flavor of the drink.
        /// </summary>
        /// <param name="flavor"></param>
        private void SelectFlavor(SodasaurusFlavor flavor)
        {
            if (DataContext is Order order)
            {
                soda.Flavor = flavor;
                Flavor = flavor;
            }
        }

        /// <summary>
        /// Click event for the cherry button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectCherry(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Cherry);
        }

        /// <summary>
        /// Click event for the chocolate button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectChocolate(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Chocolate);
        }

        /// <summary>
        /// Click event for the cola button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectCola(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Cola);
        }

        /// <summary>
        /// Click event for the cherry button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectLime(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Lime);
        }

        /// <summary>
        /// Click event for the orange button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectOrange(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Orange);
        }

        /// <summary>
        /// Click event for the root beer button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectRootBeer(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.RootBeer);
        }

        /// <summary>
        /// Click event for the vanilla button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectVanilla(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Vanilla);
        }

        /// <summary>
        /// Click event for the done button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new DrinkSelection());
            }
        }
    }
}
