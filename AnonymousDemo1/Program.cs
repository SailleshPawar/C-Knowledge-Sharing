using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AnonymousDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var anonymousType = new { FirsName = "Saillesh", LastName = "pawar" };
            
            WriteLine(anonymousType.FirsName + anonymousType.LastName);
            ReadLine();
        }
    }
}
