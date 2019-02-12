using DAL;
using ReusableLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithEnum
{
    class Program
    {
        static void Main(string[] args)
        {

            OrderDal dal = new OrderDal();
            var orders = dal.getEnumOrders();
            //here we are printing the Orders to the User 

            //for the user readability purpose the status are not understandable
            foreach (OrderMasterNew orderMaster in orders)
            {
                Console.WriteLine($"Customer Name {orderMaster.OrderCreatedby} OrderId {orderMaster.OrderId} && MobileNo {orderMaster.MobileNo} && Status {orderMaster.Status}");
            }
        }

        public void checkOrderTypeWithEnum(string status)
        {

            //Developer knows what is 1 it's a OrderedPlaced
            if (status.Equals(EStatus.OrderedPlaced.ToString()))
            {
                Console.WriteLine("Order type OrderedPlaced");
            }

            else if (status.Equals(EStatus.Delivered))
            {
                Console.WriteLine("Order type Delivered");
            }
            else if (status.Equals(EStatus.Cancelled))
            {
                Console.WriteLine("Order type Cancelled");
            }
        }


        public void checkOrderTypeWithEnum(EStatus status)
        {

            //Developer knows what is 1 it's a OrderedPlaced
            if (status.Equals(EStatus.OrderedPlaced))
            {
                Console.WriteLine("Order type OrderedPlaced");
            }

            else if (status.Equals(EStatus.Delivered))
            {
                Console.WriteLine("Order type Delivered");
            }
            else if (status.Equals(EStatus.Cancelled))
            {
                Console.WriteLine("Order type Cancelled");
            }
        }



    }
}
