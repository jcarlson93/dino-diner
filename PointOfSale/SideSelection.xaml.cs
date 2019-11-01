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
                side = value;
            }
        }

        /// <summary>
        /// Constructor for the side selection class.
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded constructor for the side selection class.
        /// </summary>
        /// <param name="side">The side that has been selected.</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }

        /// <summary>
        /// Helper function to add the side to the order.
        /// </summary>
        /// <param name="side"></param>
        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Add(side);
                Side = side;
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
                Side.Size = size;
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
            /*BtnAddFryceritops.IsEnabled = false;
            BtnAddMeteorMacAndCheese.IsEnabled = false;
            BtnAddMezzorellaSticks.IsEnabled = false;
            BtnAddTriceritots.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;*/
        }

        /// <summary>
        /// Click event for the triceritots button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
            /*BtnAddFryceritops.IsEnabled = false;
            BtnAddMeteorMacAndCheese.IsEnabled = false;
            BtnAddMezzorellaSticks.IsEnabled = false;
            BtnAddTriceritots.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;*/
        }

        /// <summary>
        /// Click event for the meteor mac and cheese button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
            /*BtnAddFryceritops.IsEnabled = false;
            BtnAddMeteorMacAndCheese.IsEnabled = false;
            BtnAddMezzorellaSticks.IsEnabled = false;
            BtnAddTriceritots.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;*/
        }

        /// <summary>
        /// Click event for the mezzorella sticks button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
            /*BtnAddFryceritops.IsEnabled = false;
            BtnAddMeteorMacAndCheese.IsEnabled = false;
            BtnAddMezzorellaSticks.IsEnabled = false;
            BtnAddTriceritots.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;*/
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
    }
}
