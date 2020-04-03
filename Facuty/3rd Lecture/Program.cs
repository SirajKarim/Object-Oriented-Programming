using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            //obj.GetId = 61918;
            obj.GetName = "Siraj";
            obj.GetMarks = 550;
            Console.WriteLine(obj.GetId);
            Console.WriteLine(obj.GetName);
            Console.WriteLine(obj.GetMarks);
            ////sample c = new sample();
            ////Console.ReadLine();
            //sample s = new sample();
            //s.Num1 = 619;
            //s.Num1 = 666595;
            //Console.WriteLine(s.Num1);
           
        }
    }
}
