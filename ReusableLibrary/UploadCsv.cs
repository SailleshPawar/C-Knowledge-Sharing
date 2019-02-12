using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReusableLibrary
{

    public class DataProgress
    {
        public delegate void InformUi(string count); // Step 1
        public InformUi updateUi = null; // Step 2
        private List<Customer> customers = new List<Customer>();

        public void Upload()
        {

            //Read data from dataset or convert csv to dataset and insert into db
            customers = mockCustomers();
            foreach(var cust in customers) {
                //inserting into database
                if ((customers.IndexOf(cust) + 1) %1000 == 0) 
                {
                    if (customers.IndexOf(cust).Equals(customers.Count() - 1))
                        {
                        updateUi("File processed successfully");
                    }
                    else
                    { 
                    updateUi((customers.IndexOf(cust) + 1).ToString() + " records processed"); //
                    }
                }
                 
            }
        }


        private List<Customer> mockCustomers()
        {
            var customers = new List<Customer>();
            #region dirtyCode
            for(int i = 0;i< 100000; i++)
            {
                customers.Add(new Customer()
                {
                    LastName = "pawar",
                    Name = "saillesh"
                });
            }
            #endregion
            return customers;
        }


    }
}
