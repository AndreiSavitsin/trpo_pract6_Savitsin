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
    /// Логика взаимодействия для DeliveryInformationPage.xaml
    /// </summary>
    public partial class DeliveryInformationPage : Page
    {
        public DeliveryInformationPage()
        {
            InitializeComponent();
        }

        private void CancelOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите отменить доставку?",
                "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                NavigationService.Navigate(new DeliveryOrderPage());
            }
        }
    }
}
