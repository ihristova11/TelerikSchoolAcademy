
namespace _1_2.SelectEmployeesWithSQLQuery
{
    using System;
    using System.Linq; 
    using System.Collections;
   

    class UseSQLQuery
    {
        static void Main(string[] args)
        {
            TelerikAcademyEntities db = new TelerikAcademyEntities();

            foreach (var e in db.Employees)
            {
                Console.WriteLine("Product: {0}, {1}, {2};", e.FirstName, e.Departments, e.Addresses.Towns);
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine();

            foreach (var e in db.Employees.Include("Addresses"))
            {
                Console.WriteLine("Product: {0}, {1}, {2};", e.FirstName, e.Departments, e.Addresses.Towns);
            }

            // Task 2   

            IEnumerable query = db.Employees.ToList()
            .Select(x => x.Addresses).ToList()
            .Select(t => t.Towns).ToList()
            .Where(t => t.Name == "Sofia");
            foreach (var t in query)
            {
                Console.WriteLine(t);
            } // made 1292 queries
            IEnumerable querySmart = db.Employees
            .Select(x => x.Addresses)
            .Select(t => t.Towns)
            .Where(t => t.Name == "Sofia").ToList();
            foreach (var t in querySmart)
            {
                Console.WriteLine(t);
            } // made 2 queries
        }
    }
}