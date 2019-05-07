using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CustomersDBEntities customersDBEntities = new CustomersDBEntities())

            {
                List<Customer> customers = (from c in customersDBEntities.Customers
                                 select c).ToList();
                List<Customer> customersMS = customersDBEntities.Customers.ToList();
                                            
                Console.WriteLine();

            }
        }
    }
}
