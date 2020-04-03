using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleem2
{
    class c:b
    {
        public c(int b):base(ref b)
        {
            b = b+b;
            Console.WriteLine(b);
        }
    }
}
