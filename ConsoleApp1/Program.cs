using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = "saillesh";
            Console.WriteLine(x.GetType());
            Console.WriteLine(x);

            dynamic value = "sallesh";
            value = 1;
            Console.WriteLine(value.GetType());
            Console.WriteLine(value);
        }
    }
}
