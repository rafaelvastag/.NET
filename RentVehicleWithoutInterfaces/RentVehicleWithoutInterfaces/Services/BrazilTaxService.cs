using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if (100.00 >= amount)
            {
                return amount * 0.2;
            } 
            else
            {
                return amount * 0.15;
            }
        }
    }
}
