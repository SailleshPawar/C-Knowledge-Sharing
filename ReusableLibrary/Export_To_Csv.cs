using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class Export_To_Excel
    {

        private static string GetHeader(Type T)
        {
            var properties = T.GetProperties(BindingFlags.Public | BindingFlags.Instance
                 | BindingFlags.GetProperty | BindingFlags.SetProperty);
            var columns = properties.Select(a => a.Name).ToArray();
            var header = string.Join(",".ToString(), columns);
            return header;
        }

        public static PropertyInfo[] GetOrderedProperties(Type type)
        {
            Dictionary<Type, int> lookup = new Dictionary<Type, int>();

            int count = 0;
            lookup[type] = count++;
            Type parent = type.BaseType;
            while (parent != null)
            {
                lookup[parent] = count;
                count++;
                parent = parent.BaseType;
            }

            return type.GetProperties()
                .OrderByDescending(prop => lookup[prop.DeclaringType]).ToArray();
        }

        public static string ToCsv<T>(string separator, List<T> objectlist)
        {
            StringBuilder csvdata = new StringBuilder("");
            Type t = objectlist[0].GetType();
            PropertyInfo[] properties = t.GetProperties().ToArray();
            StringBuilder strHeader = new StringBuilder("");
            string header = GetAttributeDisplayName(properties, separator);
            csvdata.AppendLine(header);
            foreach (var o in objectlist)
                csvdata.AppendLine(ToCsvFields(separator, properties, o).ToString());
            return csvdata.ToString();
        }

        private static StringBuilder ToCsvFields(string separator, PropertyInfo[] fields, object o)
        {
            StringBuilder line = new StringBuilder();

            foreach (var f in fields)
            {
                if (line.Length > 0)
                    line.Append(separator);

                var x = f.GetValue(o);

                if (x != null)
                    line.Append(x.ToString());
            }
            return line;
        }




        /// <summary>
        /// Get the Display Name data header from the Class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static string GetAttributeDisplayName(PropertyInfo[] properties, string separator)
        {
            StringBuilder sb = new StringBuilder("");
            int counter = 0;
            foreach (var item in properties)
            {
            if (counter.Equals(0))
                {

                   sb.Append(item.Name);
                    counter++;
                }
                else
                {

                sb.Append("," + item.Name);
                        
                    counter++;
                }

             

            }
                //sb.AppendLine(String.Join(separator, properties.Select(f => f.Name).ToArray()));
               
            

            return sb.ToString();
        }





    }
}
