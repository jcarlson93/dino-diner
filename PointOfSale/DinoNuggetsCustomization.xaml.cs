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
        /// Click event for the Add Nugget button, adds a nugget to the Dino Nuggets order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            nugget.AddNugget();
        }

        /// <summary>
        /// Click event for the done button; goes back to the entree selection page if it can,
        /// if it cannot it will go back to the Menu Category Selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
