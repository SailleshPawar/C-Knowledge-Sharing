using ReusableLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace VarDemoSecond
{
    class Program
    {
        static void Main(string[] args)
        {
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


            //creating a anonomous type from orderMaster
            var anonymousClass = lstOrderMaster.Select(x => new
            {
                OrderIDNew = x.OrderId,
                StatusNew = x.Status
            });

            foreach (var item in anonymousClass)
            {
                WriteLine($"The OrderId is {item.OrderIDNew} and Status is {item.StatusNew}");
            }
            

            ReadKey();

        }
    }
}
