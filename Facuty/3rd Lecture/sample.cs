using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_Lecture
{
    class sample
    {
        private int id=61917;
        private string name;
        private int marks;
        public int GetId
        {
            get { return id; }
           // set { id = value; }
        }
        public string GetName
        {
            get { return name; }
            set { name = value; }
        }
        public int GetMarks
        {
            get { return marks; }
            set { marks = value; }
        }
        //private int num1 = 23;
        //public int Num1
        //{

        //    set { num1 = value; }
        //    get { return num1; }

        //}
        //public sample()
        //{
        //    Console.WriteLine("Constructor");
        //}
        //~sample()
        //{
        //    Console.WriteLine("Destructor");
        //}
    }
}
