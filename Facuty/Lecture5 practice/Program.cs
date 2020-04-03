using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 c = new Class2();
            c.GetDetails();
            c.PrintDetails();
            Class3 d = new Class3();
            d.SecondClassGetDetails();
            d.SecondClassPrintDetails();
        }
    }
}
