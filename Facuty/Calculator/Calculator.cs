using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public decimal add(decimal num1, decimal num2)
        {
            decimal total = num1 + num2;
            return total;
        }
        public decimal sub(decimal num1, decimal num2)
        {
            decimal total = num1 - num2;
            return total;
        }
        public decimal multi(decimal num1, decimal num2)
        {
            decimal total = num1 * num2;
            return total;
        }
        public decimal div(decimal num1, decimal num2)
        {
            decimal total = num1 / num2;
            return total;
        }
    }
}
