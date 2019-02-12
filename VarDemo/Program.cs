using DAL;
using ReusableLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerVaraible = 10;
            string name = "Saillesh";
            var values = 1;

            OrderDal dal = new OrderDal();
            List<OrderMasterNew> order = dal.getEnumOrders();


            var anonymous = new { name = "saillesh", code = "123" };
   
            Console.WriteLine(anonymous.name);
           
            ReadLine();
        }
    }
}
