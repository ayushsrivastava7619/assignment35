using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            internalprotected obj = new internalprotected();
            string x = Console.ReadLine();
            obj.ab = int.Parse(x);
            obj.method();
            Console.Read();
        }
    }
}