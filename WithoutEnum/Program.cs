using DAL;
using ReusableLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutEnum
{
    class Program
    {
        static void Main(string[] args)
        {

            checkOrderType(1);
            OrderDal dal = new OrderDal();
            var orders=dal.getOrders();
            //here we are printing the Orders to the User 

            //for the user readability purpose the status are not understandable
            foreach (OrderMaster orderMaster in orders)
            {
                Console.WriteLine($"Customer Name {orderMaster.OrderCreatedby} OrderId {orderMaster.OrderId} && MobileNo {orderMaster.MobileNo} && Status {orderMaster.Status}");

            }
            Console.ReadLine();
        }

        public  static void checkOrderType(int type)
        {

            if (type == 1)
            {
                ///do something
                Console.WriteLine("Order type OrderedPlaced");
            }

            else if (type == 3)
            {
                ///do something
                Console.WriteLine("Order type Delivered");
            }
            else if (type == 4)
            {
                ///do something
                Console.WriteLine("Order type Cancelled");
            }
            else
            {
                ///do something
                Console.WriteLine("Default");
            }
        }
    }
}
