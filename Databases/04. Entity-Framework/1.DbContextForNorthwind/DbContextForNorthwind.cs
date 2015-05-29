using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DbContextForNorthwind
{
    class DbContextForNorthwind
    {
        static void Main(string[] args)
        {
            NorthwindEntities nwDB = new NorthwindEntities();
            var clients = from client in nwDB.Customers
                          select client.ContactName;
            foreach (var client in clients)
            {
                Console.WriteLine(client);
            }
        }
    }
}

