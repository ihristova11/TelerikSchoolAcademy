using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.EmployeesToAccessProperties
{
    class InheritEmployee
    {
        static void Main(string[] args)
        {
            Employees extended = new Employees();
            NorthwindEntities context = new NorthwindEntities();
            extended = context.Employees.Find(1);
            foreach (var item in extended.Territories)
            {
                Console.WriteLine("Teritory description - {0}", item.TerritoryDescription);
            }
        }
    }
}