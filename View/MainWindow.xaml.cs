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

namespace MvvmQuete
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ShopViewModel ShopViewModel { get; set; }
        public MainWindow()
        {
            ShopViewModel = new ShopViewModel();
            DataContext = ShopViewModel;
            InitializeComponent();
        }

        private void btn_AddShop(object sender, RoutedEventArgs e)
        {
            ShopViewModel.AddShop(Convert.ToInt32(txtShopId.Text), txtShopName.Text, txtCountry.Text);
        }
    }
}
