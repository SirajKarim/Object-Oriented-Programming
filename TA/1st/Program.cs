using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st
{
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.name = "siraj";
            s1.id = 61917;
            Console.WriteLine("name="+s1.name);
            Console.WriteLine("id="+s1.id);
            student s2 = new student();
            s2.name = "Moid";
            s2.id = 61918;
            Console.WriteLine("name="+s2.name);
            Console.WriteLine("id="+s2.id);

        }
    }
}
