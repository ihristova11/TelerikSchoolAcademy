using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ConcurrentChanges
{
    class ConcurrentChanges
    {
        static void Main(string[] args)
        {
            using (NorthwindEntities northwindEntities1 = new NorthwindEntities())
            {
                using (NorthwindEntities northwindEntities2 = new NorthwindEntities())
                {
                    Customers customerByFirstDataContext = northwindEntities1.Customers.Find("CHOPS");
                    customerByFirstDataContext.Region = "SW";
                    Customers customerBySecondDataContext = northwindEntities2.Customers.Find("CHOPS");
                    customerBySecondDataContext.Region = "SSWW";
                    northwindEntities1.SaveChanges();
                    northwindEntities2.SaveChanges();
                }
            }
            Console.WriteLine("Changes successfully made!");
        }
    }
}