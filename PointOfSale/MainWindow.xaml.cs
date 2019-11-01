/* Main Window Page
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor for the main window class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            OrderControl.NavigationService = OrderUI.NavigationService;
        }

        /// <summary>
        /// Binds the order user interface data context with the framework element data context.
        /// </summary>
        private void BindDataContextToPage()
        {
            if (OrderUI.Content is FrameworkElement element)
            {
                element.DataContext = OrderUI.DataContext;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            SetFrameDataContext();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            SetFrameDataContext();
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetFrameDataContext()
        {
            FrameworkElement content = OrderUI.Content as FrameworkElement;
            if (content == null) return;
            content.DataContext = OrderUI.DataContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (OrderUI.NavigationService.CanGoBack)
            {
                OrderUI.NavigationService.GoBack();
            }
            else
            {
                OrderUI.NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
