using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DynamicDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = XDocument.Load("Employee.xml").AsExpando();
            foreach (var emp in doc.Employees)
            {
                Console.WriteLine(emp.FirstName);
            }
        }
        

    }
    public static class Extension
    {
        public static dynamic AsExpando(this XDocument document)
        {
            return CreateExpando(document.Root);
        }

        public static dynamic CreateExpando(XElement element)
        {
            var result = new ExpandoObject() as IDictionary<string, object>;
            if (element.Elements().Any(e => e.HasElements))
            {
                var list = new List<ExpandoObject>();
                result.Add(element.Name.ToString(), list);
                foreach (var childElement in element.Elements())
                {
                    list.Add(CreateExpando(childElement));
                }

            }
            else
            {
                foreach (var leafElement in element.Elements())
                {
                    result.Add(leafElement.Name.ToString(),leafElement.Value);
                }
            }
            return result;
        }
    }


}
