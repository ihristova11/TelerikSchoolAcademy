using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OperationsWithCustomers
{
    class DAO
    {
        static void Main(string[] args)
        {

            Edit("ALFKI", "Plamen");
            Add("GRIVICA", "T233I");
        }

        static void Add(string name, string id)
        {
            Customers newCustomer = new Customers()
            {
                CompanyName = name,
                CustomerID = id
            };

            using (NorthwindEntities db = new NorthwindEntities())
            {
                bool isInDB = IsInDataBase(db, id);

                if (!isInDB)
                {
                    db.Customers.Add(newCustomer);
                    db.SaveChanges();
                    Console.WriteLine("Added Successful.");
                }
                else
                {
                    throw new ArgumentException("Such customer already exists");
                }
            }
        }

        static void Edit(string id, string newContactName)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var customer = db.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
                customer.ContactName = newContactName;
                db.SaveChanges();
            }
        }

        static void Delete(string id)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var customer = db.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }

        static bool IsInDataBase(NorthwindEntities db, string id)
        {
            bool alreadyInDB = db.Customers.Where(a => a.CustomerID == id).Any();
            return alreadyInDB;
        }
    }
}
