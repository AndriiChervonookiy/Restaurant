using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Product : Restaurant
    {
        private int id;
        private string title;
        private int count;
        private float price;
        public int Id
        {
            get => this.id;
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Title
        {
            get => this.title;
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        public int Count
        {
            get => this.count;
            set
            {
                count = value;
                OnPropertyChanged("Count");
            }
        }
        public float Price
        {
            get => this.price;
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }
    }
}
