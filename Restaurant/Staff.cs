using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Staff : Restaurant
    {
        private int id;
        private string name;
        private string surname;
        private float salary;
        public int Id
        {
            get => this.id;
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Name
        {
            get => this.name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Surname
        {
            get => this.surname;
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }
        public float Salary
        {
            get => this.salary;
            set
            {
                salary = value;
                OnPropertyChanged("Salary");
            }
        }
    }
}
