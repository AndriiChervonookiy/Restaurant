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
using Restaurant;
using RestaurantApp;

namespace Restaurant
{
    /// <summary>
    /// Логика взаимодействия для Products.xaml
    /// </summary>
    public partial class Products : Window
    {
        public Products()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel("products");
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
            else if (str == "Menu")
            {
                Menu Window = new Menu();
                Window.Show();
                this.Close();
            }
            else if (str == "MainWindow")
            {
                MainWindow Window = new MainWindow();
                Window.Show();
                this.Close();
            }
            else if (str == "Order")
            {
                Order Window = new Order();
                Window.Show();
                this.Close();
            }
        }
    }
}
