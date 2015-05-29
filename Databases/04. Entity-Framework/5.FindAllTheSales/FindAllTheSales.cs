using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FindAllTheSales
{
    class FindAllTheSales
    {


        static void FindAllSalesByDateRange(string region, int startDate, int endDate)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var sales = from order in db.Orders
                            join orderDetails in db.Order_Details
                            on order.OrderID equals orderDetails.OrderID
                            where (order.ShipRegion == region && order.OrderDate.Value.Year == startDate && order.ShippedDate.Value.Year == endDate)
                            select new
                            {
                                Quantity = orderDetails.Quantity,
                                Region = order.ShipRegion,
                                Country = order.ShipCountry
                            };

                foreach (var sale in sales)
                {
                    Console.WriteLine("Ship Region: {0}, Ship Country: {1}, Order Quantity: {2}",
                                        sale.Region, sale.Country, sale.Quantity);
                }
            }
        }


        static void Main(string[] args)
        {
            FindAllSalesByDateRange("Canada", 21, 28);
        }
    }
}
