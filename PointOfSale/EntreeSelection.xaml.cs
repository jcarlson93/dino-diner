/* Entree Selection Page
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        // Private backing variables.
        private Entree entree;

        /// <summary>
        /// Gets or sets the Entree selected.
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                entree = value;
            }
        }

        /// <summary>
        /// Constructor for the Entree Selection Class.
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded constructor for the Entree Selection Class.
        /// </summary>
        /// <param name="entree">The entree that has been changed.</param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            Entree = entree;
        }

        /// <summary>
        /// Helper function to add the entree to the Order.
        /// </summary>
        /// <param name="entree"></param>
        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                Entree = entree;
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Click event for adding a brontowurst to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnAddBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();
                order.Add(bw);
                NavigationService.Navigate(new BrontowurstCustomization(bw));
            }
        }

        /// <summary>
        /// Click event for adding dino nuggets to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnAddDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nuggets = new DinoNuggets();
                order.Add(nuggets);
                NavigationService.Navigate(new DinoNuggetsCustomization(nuggets));
            }
        }

        /// <summary>
        /// Click event for adding a prehistoric PB&J to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new PrehistoricPBJCustomization(pbj));
            }
        }

        /// <summary>
        /// Click event for adding pterodactyl wings to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnAddPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings wings = new PterodactylWings();
                order.Add(wings);
                NavigationService.Navigate(new PterodactylWingsCustomization(wings));
            }
        }

        /// <summary>
        /// Click event for adding a steakosaurus burger to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnAddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger burger = new SteakosaurusBurger();
                order.Add(burger);
                NavigationService.Navigate(new SteakosaurusBurgerCustomization(burger));
            }
        }

        /// <summary>
        /// Click event for adding a t-rex king burger to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnAddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger burger = new TRexKingBurger();
                order.Add(burger);
                NavigationService.Navigate(new TRexKingBurgerCustomization(burger));
            }
        }

        /// <summary>
        /// Click event for adding a velociwrap to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnAddVelociwrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap wrap = new VelociWrap();
                order.Add(wrap);
                NavigationService.Navigate(new VelociWrapCustomization(wrap));
            }
        }
    }
}
