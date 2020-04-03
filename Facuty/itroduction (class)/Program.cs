using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itroduction__class_
{
    class Program
    {
        static void Main(string[] args)
        {
            myclass objmyclass = new myclass();                 //here we create a object of class whose name is objmyclass
            objmyclass.myprocedure();                           // i call a method  procedure
            objmyclass.myfunction();                            // i call a method function 
            string value = objmyclass.myfunction();             // save a value of object of mthd function in value
            Console.WriteLine(value);                           //print value

        }
        class myclass                                           //here we create a class
        {
            public void myprocedure()                           //create a methd name procedure
            {
                Console.WriteLine("This is Procedure");
            }
            public string myfunction()                          //create a methd my fuction
            {
                return "This is function";
            }
        }
    }
}
