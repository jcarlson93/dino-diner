/* Brontowurst Customization Page
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
    /// Interaction logic for BrontowurstCustomization.xaml
    /// </summary>
    public partial class BrontowurstCustomization : Page
    {
        // Private backing variables.
        private Brontowurst bw;
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for the Brontowurst Customization page.
        /// </summary>
        /// <param name="bw">The brontowurst order item to be customized.</param>
        public BrontowurstCustomization(Brontowurst bw)
        {
            InitializeComponent();
            this.bw = bw;
        }

        /// <summary>
        /// Overloaded constructor for the Brontowurst Customization page. Passes in the selected entree from the Combo Selection page.
        /// </summary>
        /// <param name="combo">The combo that was picked in the Combo Selection page.</param>
        public BrontowurstCustomization(CretaceousCombo combo)
        {
            InitializeComponent();
            this.bw = (Brontowurst)combo.Entree;
            this.combo = combo;
        }

        /// <summary>
        /// Click event for the hold bun button, holds the bun on the brontowurst.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            bw.HoldBun();
        }

        /// <summary>
        /// Click event for the hold peppers button, holds the peppers on the brontowurst.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            bw.HoldPeppers();
        }

        /// <summary>
        /// Click event for the hold onions button, holds the onions on the brontowurst.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnions(object sender, RoutedEventArgs args)
        {
            bw.HoldOnion();
        }

        /// <summary>
        /// Click event for the done button; goes back to the entree selection page if it can,
        /// if it cannot it will go back to the Menu Category Selection page.
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
