/* Prehistoric PB&J Customization Page
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
    /// Interaction logic for PrehistoricPBJCustomization.xaml
    /// </summary>
    public partial class PrehistoricPBJCustomization : Page
    {
        // Private backing variables.
        private PrehistoricPBJ pbj;
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for the Prehistoric PB&J Customization page.
        /// </summary>
        /// <param name="pbj">The Prehistoric PB&J order item to be customized.</param>
        public PrehistoricPBJCustomization(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        /// <summary>
        /// Overloaded constructor for the Prehistoric PB&J Customization page. Passes in the selected entree from the Combo Selection page.
        /// </summary>
        /// <param name="combo">The combo that was picked in the Combo Selection page.</param>
        public PrehistoricPBJCustomization(CretaceousCombo combo)
        {
            InitializeComponent();
            this.pbj = (PrehistoricPBJ)combo.Entree;
            this.combo = combo;
        }

        /// <summary>
        /// Click event for the hold peanut butter button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
        }

        /// <summary>
        /// Click event for the hold jelly button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }

        /// <summary>
        /// Click event for the done button.
        /// If Prehistoric PB&J was selected as the entree from the Combo Selection page, navigate to the Cusomize Combo page.
        /// If Prehistoric PB&J was selected as the entree from the Entree Selection page, navigate back to the Entree Selection page.
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
