using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleem2
{
    class b:a
    {
       
        public b(ref int a):base(ref a)
        {
            a = a + a; 
        }
    }
}
