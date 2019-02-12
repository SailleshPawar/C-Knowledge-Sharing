using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            Comparision<int> compareInt = new Comparision<int>();
            Console.WriteLine(compareInt.Compare(10, 10));

            Comparision<string> compareString = new Comparision<string>();
            Console.WriteLine(compareString.Compare("saillesh", "Digambar"));
            Console.ReadLine();

        }


    }

 


    public class Comparision<GenericType>
    {
        public bool Compare(GenericType value1, GenericType value2)
        {
            bool status = false;

            if (value1.Equals(value2))
            {
                status = true;
            }
            return status;
        }
    }

}
