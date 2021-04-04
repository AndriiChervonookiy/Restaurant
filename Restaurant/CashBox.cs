using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Cashbox : Restaurant
    {
        static int ClientsPerDay { get; set; }
        static float ProfitPerDay { get; set; }
        float AveragePayPerVisit = ClientsPerDay / ProfitPerDay;
    }
}
