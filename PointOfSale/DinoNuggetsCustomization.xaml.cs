/* Dino Nugget Customization Page
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
    /// Interaction logic for DinoNuggetsCustomization.xaml
    /// </summary>
    public partial class DinoNuggetsCustomization : Page
    {
        // Private backing variables.
        private DinoNuggets nugget;
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for the Dino Nuggets Customization page.
        /// </summary>
        /// <param name="nugget">The dino nugget order item to customize.</param>
        public DinoNuggetsCustomization(DinoNuggets nugget)
        {
            InitializeComponent();
            this.nugget = nugget;
        }

        /// <summary>
        /// Overloaded constructor for the Dino Nuggets Customization page. Passes in the selected entree from the Combo Selection page.
        /// </summary>
        /// <param name="combo">The combo that was picked in the Combo Selection page.</param>
        public DinoNuggetsCustomization(CretaceousCombo combo)
        {
            InitializeComponent();
            this.nugget = (DinoNuggets)combo.Entree;
            this.combo = combo;
        }

        /// <summary>
        /// Click event for the Add Nugget button, adds a nugget to the Dino Nuggets order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            nugget.AddNugget();
        }

        /// <summary>
        /// Click event for the done button.
        /// If Dino Nuggets were selected as the entree from the Combo Selection page, navigate to the Cusomize Combo page.
        /// If Dino Nuggets were selected as the entree from the Entree Selection page, navigate back to the Entree Selection page.
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
