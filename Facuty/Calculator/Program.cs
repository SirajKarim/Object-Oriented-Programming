using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Enter First No");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator");
            char oper = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second No");
            decimal b = decimal.Parse(Console.ReadLine());
            Calculator objcalculate = new Calculator();
            objcalculate.add(a, b);
            if (oper=='+')
            {
                Console.WriteLine(objcalculate.add(a,b));
            }
            else if (oper=='-')
            {
                Console.WriteLine(objcalculate.sub(a,b));
            }
            else if (oper == '*')
            {
                Console.WriteLine(objcalculate.multi(a, b));
            }
            else if (oper == '/')
            {
                Console.WriteLine(objcalculate.div(a, b));
            }
        }
    }
}
