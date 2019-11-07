/* Side Selection Page
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        // Private backing variables.
        private Side side;
        private CretaceousCombo combo;

        /// <summary>
        /// Gets and sets the side.
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                this.side = value;
            }
        }

        /// <summary>
        /// Constructor for the Side Selection class.
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded constructor for the Side Selection page.
        /// </summary>
        /// <param name="side">The side that has been selected.</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        /// <summary>
        /// Overloaded constructor for the Side Selection page. Passes in a combo if coming from Customize Combo page.
        /// </summary>
        /// <param name="combo"></param>
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.side = combo.Side;
        }

        /// <summary>
        /// Helper function to add the side to the order.
        /// </summary>
        /// <param name="side"></param>
        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    this.combo.Side = side;
                    this.Side = side;
                }
                else
                {
                    order.Add(side);
                    this.Side = side;
                }
            }
        }

        /// <summary>
        /// Helper function to set the size of the selected side.
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
            {
                if (combo != null)
                {
                    this.combo.Side.Size = size;
                }
                this.Side.Size = size;
            }
        }

        /// <summary>
        /// Click event for the fryceritops button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
        }

        /// <summary>
        /// Click event for the triceritots button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }

        /// <summary>
        /// Click event for the meteor mac and cheese button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        /// <summary>
        /// Click event for the mezzorella sticks button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
        }

        /// <summary>
        /// Click event for making the side large.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Click event for making the side medium.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Click event for making the side small.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Click event for the Done button.
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
