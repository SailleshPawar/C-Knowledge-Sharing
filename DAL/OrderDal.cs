using ReusableLibrary;
using System.Collections.Generic;

namespace DAL
{
    public class OrderDal
    {
        public List<OrderMaster> getOrders()
        {
            List <OrderMaster> orders = new List<OrderMaster>();
            orders.Add( new OrderMaster
            {
                OrderCreatedby = "Saillesh Pawar",
                MobileNo = 999999999,
                OrderId = 001,
                Status = 1
            });

            orders.Add(new OrderMaster
            {
                OrderCreatedby = "Virender Pawar",
                MobileNo = 999999992,
                OrderId = 003,
                Status = 2
            });


            orders.Add(new OrderMaster
            {
                OrderCreatedby = "Rakesh Pawar",
                MobileNo = 99999993,
                OrderId = 004,
                Status = 5
            });
            return orders;
        }


        public List<OrderMasterNew> getEnumOrders()
        {
            List<OrderMasterNew> orders = new List<OrderMasterNew>();
            orders.Add(new OrderMasterNew
            {
                OrderCreatedby = "Saillesh Pawar",
                MobileNo = 999999999,
                OrderId = 001,
                Status = (EStatus)1
            });

            orders.Add(new OrderMasterNew
            {
                OrderCreatedby = "Virender Pawar",
                MobileNo = 999999992,
                OrderId = 003,
                Status = (EStatus)2
            });


            orders.Add(new OrderMasterNew
            {
                OrderCreatedby = "Rakesh Pawar",
                MobileNo = 99999993,
                OrderId = 004,
                Status = (EStatus)5
            });
            return orders;
        }

    }
}
