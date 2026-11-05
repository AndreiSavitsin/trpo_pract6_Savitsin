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

namespace trpo_pract6_Savitsin
{
    /// <summary>
    /// Логика взаимодействия для DeliveryOrderPage.xaml
    /// </summary>
    public partial class DeliveryOrderPage : Page
    {
        public DeliveryOrderPage()
        {
            InitializeComponent();
            if (Agreement.IsChecked == false)
            {
                btnMakeOrder.IsEnabled = false;
            }
            else
            {
                btnMakeOrder.IsEnabled = true;
            }
        }

        private void btnMakeOrder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DeliveryInformationPage());
        }

        private void ChangeThemeBtn_Click(object sender, RoutedEventArgs e)
        {
            ThemeHelper.Toggle();
        }

        private void Agreement_Click(object sender, RoutedEventArgs e)
        {
            if (Agreement.IsChecked == false)
            {
                btnMakeOrder.IsEnabled = false;
            }
            else
            {
                btnMakeOrder.IsEnabled = true;
            }
        }
    }
}
