using Restaurant;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using Menu = Restaurant.Menu;

namespace Restaurant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string sqlconn = "Data Source=SQL5103.site4now.net;Initial Catalog=DB_A70B8E_Rest;Persist Security Info=True;User ID=DB_A70B8E_Rest_admin;Password=Cerv_7kxc;";
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel("staff");
        }
        private void EnableTrue()
        {
            listBoxStaff.SelectedIndex = -1;
            listBoxStaff.IsEnabled = true;
            buttonHireAnEmployee.IsEnabled = true;
            buttonHome.IsEnabled = true;
            buttonMenu.IsEnabled = true;
            buttonProducts.IsEnabled = true;
            buttonOrder.IsEnabled = true;
            buttonUpdate.IsEnabled = true;
            buttonSaveChange.Content = "Сохранить изменения";
            buttonRemuveEmployee.Content = "Удалить сотрудника";
        }
        private void buttonSaveChange_Click(object sender, RoutedEventArgs e)
        {
            if (buttonSaveChange.Content.ToString() == "Сохранить изменения")
            {
                using (SqlConnection conn = new SqlConnection(sqlconn))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE [DB_A70B8E_Rest].[dbo].[Staff] SET Name ='" + textBoxName.Text + "', Surname = '" + textBoxSurname.Text + "', Salary = '" + textBoxSalary.Text + "' WHERE Id = " + labelId.Content.ToString() + ";", conn))
                    {
                        int count = command.ExecuteNonQuery();
                        if (count > 0)
                            MessageBox.Show("Выполнено успешно");
                        else
                            MessageBox.Show("Ошибка ввода данных");
                    }
                }
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(sqlconn))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("INSERT INTO [DB_A70B8E_Rest].[dbo].[Staff]([Name], [Surname], [Salary]) VALUES('" + textBoxName.Text + "', '" + textBoxSurname.Text + "', '" + textBoxSalary.Text + "');", conn))
                    {
                        int count = command.ExecuteNonQuery();
                        if (count > 0)
                            MessageBox.Show("Выполнено успешно");
                        else
                            MessageBox.Show("Ошибка ввода данных");
                    }
                }
                EnableTrue();
                DataContext = new ApplicationViewModel("staff");
            }
        }
        private void buttonRemuveEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (buttonRemuveEmployee.Content.ToString() == "Удалить сотрудника")
                using (SqlConnection conn = new SqlConnection(sqlconn))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM [DB_A70B8E_Rest].[dbo].[Staff] WHERE Id = '" + labelId.Content.ToString() + "';", conn))
                    {
                        int count = command.ExecuteNonQuery();
                        if (count > 0)
                            MessageBox.Show("Выполнено успешно");
                        else
                            MessageBox.Show("Ошибка ввода данных");
                    }
                    DataContext = new ApplicationViewModel("staff");
                }
            else
            {
                EnableTrue();
            }
        }
        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ApplicationViewModel("staff");
        }
        private void buttonHireAnEmployee_Click(object sender, RoutedEventArgs e)
        {
            listBoxStaff.SelectedIndex = -1;
            listBoxStaff.IsEnabled = false;
            buttonHireAnEmployee.IsEnabled = false;
            buttonHome.IsEnabled = false;
            buttonMenu.IsEnabled = false;
            buttonProducts.IsEnabled = false;
            buttonOrder.IsEnabled = false;
            buttonUpdate.IsEnabled = false;
            buttonSaveChange.Content = "Нанять";
            buttonRemuveEmployee.Content = "Отменить";
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

