using Helpers;
using ReusableLibrary;
using System.Collections.Generic;
using static System.Console;
namespace GenericsExportToExcel
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            object type = 1;
            var typess = 1;
            int value = (int)type;
            System.Console.WriteLine(type);




            List<OrderMaster> lstOrderMaster = new List<OrderMaster>() {
           new OrderMaster()
            {
                MobileNo = 123,
                OrderCreatedby = "saillesh",
                OrderId = 1,
                Status = 1
           }
           ,
             new OrderMaster()
             {
                 MobileNo = 1234,
                 OrderCreatedby = "asad",
                 OrderId = 12,
                 Status = 12
             }
            };

            string csvStringOrderMasters = Export_To_Excel.ToCsv<OrderMaster>(",", lstOrderMaster);
           WriteLine("CSV Result for Order Masters");
           WriteLine(csvStringOrderMasters);

            List<Customer> customers = new List<Customer>() {
                new Customer()
                {
                    LastName="pawar",
                    Name="saillesh"
                },
                new Customer()
                {
                    Name="Snehal",
                    LastName="Thube"
                }

            };


            string csvStringCustomers = Export_To_Excel.ToCsv<Customer>(",", customers);
            WriteLine("CSV Result for Customers");
            WriteLine(csvStringCustomers);
            ReadLine();

        }
    }
}
