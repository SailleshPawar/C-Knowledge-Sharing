using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableLibrary
{
    public class OrderMaster
    {
        public int OrderId
        {
            get;
            set;
        }
        public string OrderCreatedby
        {
            get;
            set;
        }
        public long MobileNo
        {
            get;
            set;
        }

        //Status 1:OrderedPlaced  
        //Status 2:OrderAccepted  
        //Status 3:Billed  
        //Status 4:TripCreated  
        //Status 5:Delivered  
        //Status 6:Cancelled  
        public int Status
        {
            get;
            set;
        }

    }

    public class OrderMasterNew
    {
        public int OrderId
        {
            get;
            set;
        }
        public string OrderCreatedby
        {
            get;
            set;
        }
        public long MobileNo
        {
            get;
            set;
        }

        //Status 1:OrderedPlaced  
        //Status 2:OrderAccepted  
        //Status 3:Billed  
        //Status 4:TripCreated  
        //Status 5:Delivered  
        //Status 6:Cancelled  
        public EStatus Status
        {
            get;
            set;
        }

    }
    public enum EStatus
    {
        //numbers denote what status in database mean
       
        OrderedPlaced = 1,
        OrderAccepted = 2,
        Billed = 30,
        TripCreated = 4,
        Delivered = 5,
        Cancelled = 600

    };

}
