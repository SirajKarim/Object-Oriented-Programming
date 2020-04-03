using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5
{
    class Class1
    {
        public int id;
        public int Inputid()
        {
            Console.WriteLine("Enter Student ID");
            id = int.Parse(Console.ReadLine());
            return id;
        }

        public string Name;
        public void Inputname()
        {
            Console.WriteLine("Enter Student NAME");
            Name = (Console.ReadLine());
        }
        
        public string Fname;
        public void InputFname()
        {
            Console.WriteLine("Enter Student FATHERNAME");
            Fname = (Console.ReadLine());
        }

        
        public int EnterMarks;
        public void InputMarks()
        {
            Console.WriteLine("Enter Student MARKS");
            EnterMarks = int.Parse(Console.ReadLine());
        }
        
        public int PhoneNumbers;
        public void Inputphonenumber()
        {
            Console.WriteLine("Enter Student PHONENUMBER");
            PhoneNumbers = int.Parse(Console.ReadLine());
        }


        public void PrintDetails()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("                              ");
            Console.WriteLine("Your ID is {0}",id);
            Console.WriteLine("Your Name is {0}", Name);
            Console.WriteLine("Your Father Name is {0}",Fname);
            Console.WriteLine("Your Marks is {0}", EnterMarks);
            Console.WriteLine("Your Cell no is {0}",PhoneNumbers);
            Console.WriteLine("                              ");
            Console.WriteLine("==============================");
        }
       
    }
}
