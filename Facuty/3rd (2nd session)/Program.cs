using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd__2nd_session_
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            int n1=555;
            c.pro(ref n1);
            Console.WriteLine(n1);
        }
    }
}
