using System;
using System.Collections.Generic;
using System.Linq;

namespace classWork_Joining
{
    public class Program
    {
        static void Main()
        {


            var allsales = Sales.GetSales();
            var allitems = Items.GetItems();

            var groupjoin = allsales.GroupJoin(allitems, x => x.Id,
                                                          y => y.SalesId,
                                                          (x, groupedallitems) => new
                                                          {
                                                              x.Id,
                                                              x.CategoryName,
                                                              groupedallitems
                                                          });

            foreach (var item in groupjoin)
            {
                Console.WriteLine($"Category Name: {item.CategoryName}");
               foreach (var item2 in item.groupedallitems)
                {
                    Console.WriteLine($"Item name: {item2.ItemName}, ID: {item2.SalesId}, Roll Number: {item2.RollNumber}");
                }
            }

            Console.WriteLine("\n");
            
            var amountsum = allitems.Sum(x => x.Amount);
            
            Console.WriteLine( $"Amount Total: {amountsum}");

            Console.WriteLine("\n");
            var rollaverage = allitems.Average(x => x.RollNumber);
            Console.WriteLine($"Average of Roll Number: {rollaverage}");

           
        }
    }
}
