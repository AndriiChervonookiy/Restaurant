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
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }
        public void button_Click(object sender, RoutedEventArgs e)
        {
            Button Temp = sender as Button;
            string str = Temp.Name.ToString().Substring(6);
            if (str == "MainWindow")
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
            else if (str == "Order")
            {
                Order Window = new Order();
                Window.Show();
                this.Close();
            }
        }
    }
}
