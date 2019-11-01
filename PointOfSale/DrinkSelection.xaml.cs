/* Drink Selection Page
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        // Private backing variable for the drink.
        private Drink drink;

        /// <summary>
        /// Gets and sets the drink selected.
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
            }
        }

        /// <summary>
        /// Constructor for the drink selection page.
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded constructor for the drink selection page.
        /// </summary>
        /// <param name="drink">The drink that has been selected.</param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
            if (Drink is Sodasaurus soda)
            {
                SodasaurusSpecials();
            }
            if (Drink is Tyrannotea tea)
            {
                TyrannoteaSpecials();
            }
            if (Drink is JurassicJava java)
            {
                JurassicJavaSpecials();
            }
            if (Drink is Water water)
            {
                WaterSpecials();
            }
        }

        /// <summary>
        /// Navigates to the flavor selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void DrinkFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection((Sodasaurus)Drink));
        }

        /// <summary>
        /// Helper function to add the selected drink to the order.
        /// </summary>
        /// <param name="drink"></param>
        private void SelectDrink(Drink drink)
        {
            if (DataContext is Order order)
            {
                order.Add(drink);
                Drink = drink;
            }
        }

        /// <summary>
        /// Helper function that sets the size of the drink.
        /// </summary>
        /// <param name="size">The size to make the drink.</param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
            {
                Drink.Size = size;
            }
        }

        /// <summary>
        /// Helper function for displaying the Special buttons for the sodasaurus drink.
        /// </summary>
        private void SodasaurusSpecials()
        {
            BtnFlavor.Visibility = Visibility.Visible;
            BtnSweet.Visibility = Visibility.Hidden;
            BtnDecaf.Visibility = Visibility.Hidden;
            BtnLemon.Visibility = Visibility.Hidden;
            BtnCream.Visibility = Visibility.Hidden;
            BtnHoldIce.Visibility = Visibility.Visible;
            BtnAddIce.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Helper function for displaying the Special buttons for the tyrannotea drink.
        /// </summary>
        private void TyrannoteaSpecials()
        {
            BtnFlavor.Visibility = Visibility.Hidden;
            BtnSweet.Visibility = Visibility.Visible;
            BtnDecaf.Visibility = Visibility.Hidden;
            BtnLemon.Visibility = Visibility.Visible;
            BtnCream.Visibility = Visibility.Hidden;
            BtnHoldIce.Visibility = Visibility.Visible;
            BtnAddIce.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Helper function for displaying the Special buttons for the tyrannotea drink.
        /// </summary>
        private void JurassicJavaSpecials()
        {
            BtnFlavor.Visibility = Visibility.Hidden;
            BtnSweet.Visibility = Visibility.Hidden;
            BtnDecaf.Visibility = Visibility.Visible;
            BtnLemon.Visibility = Visibility.Hidden;
            BtnCream.Visibility = Visibility.Visible;
            BtnHoldIce.Visibility = Visibility.Hidden;
            BtnAddIce.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Helper function for displaying the Special buttons for the water drink.
        /// </summary>
        private void WaterSpecials()
        {
            BtnFlavor.Visibility = Visibility.Hidden;
            BtnSweet.Visibility = Visibility.Hidden;
            BtnDecaf.Visibility = Visibility.Hidden;
            BtnLemon.Visibility = Visibility.Visible;
            BtnCream.Visibility = Visibility.Hidden;
            BtnHoldIce.Visibility = Visibility.Visible;
            BtnAddIce.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Click event to add a sodasaurus drink to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnAddSodasaurus(object sender, RoutedEventArgs args)
        {
            SodasaurusSpecials();
            SelectDrink(new Sodasaurus());
        }

        /// <summary>
        /// Click event to add a tyrannotea drink to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnAddTyrannotea(object sender, RoutedEventArgs args)
        {
            TyrannoteaSpecials();
            SelectDrink(new Tyrannotea());
        }

        /// <summary>
        /// Click event to add a jurassic java drink to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnAddJurassicJava(object sender, RoutedEventArgs args)
        {
            JurassicJavaSpecials();
            SelectDrink(new JurassicJava());
        }

        /// <summary>
        /// Click event to add a water to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnAddWater(object sender, RoutedEventArgs args)
        {
            WaterSpecials();
            SelectDrink(new Water());
        }

        /// <summary>
        /// Click event to make the drink a large size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Click event to make the drink a medium size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Click event to make the drink a small size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Click event for the Sweet Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeSweet(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea tea)
            {
                tea.MakeSweet();
            }
        }

        /// <summary>
        /// Click event for the Decaf Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeDecaf(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava java)
            {
                java.Decaf = true;
            }
        }

        /// <summary>
        /// Click event for the add lemon button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnAddLemon(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea tea)
            {
                tea.AddLemon();
            }
            if (Drink is Water water)
            {
                water.AddLemon();
            }
        }

        /// <summary>
        /// Click event for the leave room for cream button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnLeaveRoomForCream(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava java)
            {
                java.LeaveRoomForCream();
            }
        }

        /// <summary>
        /// Click event for the hold ice button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnHoldIce(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.HoldIce();
            }
            if (Drink is Tyrannotea tea)
            {
                tea.HoldIce();
            }
            if (Drink is Water water)
            {
                water.HoldIce();
            }
        }

        /// <summary>
        /// Click event for the add ice button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnAddIce(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava java)
            {
                java.AddIce();
            }
        }

        /// <summary>
        /// Click event for the done button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
