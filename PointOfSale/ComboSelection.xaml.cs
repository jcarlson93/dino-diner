/* Combo Selection Page
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        // Private backing variables.
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for the Combo Selection page.
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded constructor for the combo selection class.
        /// </summary>
        /// <param name="combo">The combo that has been changed.</param>
        public ComboSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        /// <summary>
        /// Click event for the Brontowurst Combo button, adds a Brontowusrt combo to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();
                this.combo = new CretaceousCombo(bw);
                order.Add(combo);
                NavigationService.Navigate(new BrontowurstCustomization(combo));
            }
        }

        /// <summary>
        /// Click event for the Dino Nuggets Combo button, adds a Dino Nuggets combo to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nuggets = new DinoNuggets();
                this.combo = new CretaceousCombo(nuggets);
                order.Add(combo);
                NavigationService.Navigate(new DinoNuggetsCustomization(combo));
            }
        }

        /// <summary>
        /// Click event for the Prehistoric PB&J Combo button, adds a Prehistoric PB&J combo to the orer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                this.combo = new CretaceousCombo(pbj);
                order.Add(combo);
                NavigationService.Navigate(new PrehistoricPBJCustomization(combo));
            }
        }

        /// <summary>
        /// Click event for the Pterodacyl Wings Combo button, adds a Pterodactyl Wings combo to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectPterodacylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings wings = new PterodactylWings();
                this.combo = new CretaceousCombo(wings);
                order.Add(combo);
                NavigationService.Navigate(new PterodactylWingsCustomization(combo));
            }
        }

        /// <summary>
        /// Click event for the Steakosaurus Burger Combo button, adds a Steakosaurus combo to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger burger = new SteakosaurusBurger();
                this.combo = new CretaceousCombo(burger);
                order.Add(combo);
                NavigationService.Navigate(new SteakosaurusBurgerCustomization(combo));
            }
        }

        /// <summary>
        /// Click event for the T-Rex King Burger Combo button, adds a T-Rex King Burger combo to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger burger = new TRexKingBurger();
                this.combo = new CretaceousCombo(burger);
                order.Add(combo);
                NavigationService.Navigate(new TRexKingBurgerCustomization(combo));
            }
        }

        /// <summary>
        /// Click event for the Veloci-Wrap Combo button, adds a Veloci-Wrap combo to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap wrap = new VelociWrap();
                this.combo = new CretaceousCombo(wrap);
                order.Add(combo);
                NavigationService.Navigate(new VelociWrapCustomization(combo));
            }
        }
    }
}
