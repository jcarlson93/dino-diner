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
        /// Constructor for the combo selection class.
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
        /// Click event for customizing the combo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void CustomizeCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();
                CretaceousCombo combo = new CretaceousCombo(bw);
                NavigationService.Navigate(new BrontowurstCustomization(bw));
            }
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
                CretaceousCombo combo = new CretaceousCombo(bw);
                order.Add(combo);
                NavigationService.Navigate(new BrontowurstCustomization(combo));
            }
        }
    }
}
