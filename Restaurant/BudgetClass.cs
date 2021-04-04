using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class BudgetClass : Restaurant
    {
        private float budget;
        public float Budget
        {
            get => this.budget;
            set
            {
                budget = value;
                OnPropertyChanged("Budget");
            }
        }
    }
}
