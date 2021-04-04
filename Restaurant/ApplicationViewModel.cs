using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows;
using Restaurant;

namespace Restaurant
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        string connstr = "Data Source=SQL5103.site4now.net;Initial Catalog=DB_A70B8E_Rest;Persist Security Info=True;User ID=DB_A70B8E_Rest_admin;Password=Cerv_7kxc;";

        private Staff selectedStaff;
        private Product selectedProduct;
        private BudgetClass budgetClass;
        public ObservableCollection<Staff> Staffs { get; set; }
        public ObservableCollection<Product> Products { get; set; }
        public Staff SelectedStaff
        {
            get => selectedStaff;
            set
            {
                selectedStaff = value;
                OnPropertyChanged("SelectedStaff");
            }
        }
        public Product SelectedProduct
        {
            get => selectedProduct;
            set
            {
                selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }
        public ApplicationViewModel(string table)
        {
            if (table == "staff")
            {
                Staffs = new ObservableCollection<Staff>() { };
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    conn.Open();
                    string TId;
                    string TName;
                    string TSurname;
                    string TSalary;

                    using (SqlCommand command = new SqlCommand("SELECT * FROM [DB_A70B8E_Rest].[dbo].[Staff];", conn))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                TId = reader.GetValue(0).ToString();
                                TName = reader.GetValue(1).ToString();
                                TSurname = reader.GetValue(2).ToString();
                                TSalary = reader.GetValue(3).ToString();
                                Staffs.Add(new Staff() { Id = int.Parse(TId), Name = TName, Surname = TSurname, Salary = float.Parse(TSalary) });
                            }
                        }
                    }
                }
            }
            else if (table == "products")
            {
                Products = new ObservableCollection<Product>() { };
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    conn.Open();
                    string TId;
                    string TTitle;
                    string TCount;
                    string TPrice;

                    using (SqlCommand command = new SqlCommand("SELECT * FROM [DB_A70B8E_Rest].[dbo].[Products];", conn))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                TId = reader.GetValue(0).ToString();
                                TTitle = reader.GetValue(1).ToString();
                                TCount = reader.GetValue(2).ToString();
                                TPrice = reader.GetValue(3).ToString();
                                Products.Add(new Product() { Id = int.Parse(TId), Title = TTitle, Count = int.Parse(TCount), Price = float.Parse(TPrice) });
                            }
                        }
                    }
                }
            }
            else if (table == "budget")
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    conn.Open();
                    string TBudget;

                    using (SqlCommand command = new SqlCommand("SELECT * FROM [DB_A70B8E_Rest].[dbo].[Budget];", conn))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                TBudget = reader.GetValue(0).ToString();
                                budgetClass = new BudgetClass() { Budget=float.Parse(TBudget) };
                                MessageBox.Show(budgetClass.Budget.ToString());
                            }
                        }
                    }
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
