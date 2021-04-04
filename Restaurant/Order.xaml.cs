using RestaurantApp;
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
using System.Windows.Shapes;

namespace Restaurant
{
    /// <summary>
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        public Order()
        {
            InitializeComponent();
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            Button Temp = sender as Button;
            string str = Temp.Name.ToString().Substring(6);
            if (str == "Home")
            {
                Home Window = new Home();
                Window.Show();
                this.Close();
            }
            else if (str == "MainWindow")
            {
                MainWindow Window = new MainWindow();
                Window.Show();
                this.Close();
            }
            else if (str == "Menu")
            {
                Menu Window = new Menu();
                Window.Show();
                this.Close();
            }
            else if (str == "Products")
            {
                Products Window = new Products();
                Window.Show();
                this.Close();
            }
        }
    }
}
