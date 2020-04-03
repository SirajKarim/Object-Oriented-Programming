using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Address");
            string address = Console.ReadLine();

            Class1 objinput = new Class1();
            objinput.idandname(id,name);
            Class1 obj
        }
    }
}
