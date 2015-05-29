using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FindAllCustomers
{
    class FindSomeStudents
    {
        static void Main(string[] args)
        {

            int year = 1997;
            FindAllCustomers(year, "Canada");
        }

        static void FindAllCustomers(int orderDate, string shipDestination)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var orders = from order in db.Orders
                             where order.OrderDate.Value.Year == orderDate && order.ShipCountry == shipDestination
                             select order;

                foreach (var item in orders)
                {
                    Console.WriteLine("Order made by: {0} with CustomerId: {1}", item.Customers.ContactName, item.Customers.CustomerID);
                }
            }
        }
    }
}

