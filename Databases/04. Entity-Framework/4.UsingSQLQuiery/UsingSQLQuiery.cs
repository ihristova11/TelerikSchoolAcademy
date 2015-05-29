using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.UsingSQLQuiery
{
    class UsingSQLQuiery
    {


        static void FindAllCustomersWithNativeSQLQuery(int orderDate, string country)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                string sqlQuery = @"SELECT c.ContactName from Customers" +
                                  " c INNER JOIN Orders o ON o.CustomerID = c.CustomerID " +
                                  "WHERE (YEAR(o.OrderDate) = {0} AND o.ShipCountry = {1});";

                object[] parameters = { orderDate, country };
                var sqlQueryResult = db.Database.SqlQuery<string>(sqlQuery, parameters);

                foreach (var order in sqlQueryResult)
                {
                    Console.WriteLine(order);
                }
            }
        }


        static void Main(string[] args)
        {

            FindAllCustomersWithNativeSQLQuery(1997, "Canada");   


        }
    }
}
