using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment35
{
    internal class internalprotected
    {
        internal protected int ab;

        internal void method()
        {
            ab++;
            ab++;
            Console.WriteLine("internal class accessed");
            Console.WriteLine(ab);

        }
    }
}
