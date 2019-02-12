using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Does not work
            //dynamic objectDefinition= new dynamic();



            dynamic expandoObject = new ExpandoObject();
            expandoObject.Name = "Saillesh";
            expandoObject.Speak = new Action(() => Console.WriteLine(expandoObject.Name));
            expandoObject.Speak();


            foreach (var item in expandoObject)
            {
                Console.WriteLine(item.Key);

                Console.WriteLine(item.Value);
            }

        }

      
    }
}
