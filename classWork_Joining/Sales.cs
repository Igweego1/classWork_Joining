using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classWork_Joining
{
    public class Sales
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public static List<Sales> GetSales()
        {
            return new List<Sales>
            {
                new Sales  { Id = 2, CategoryName = "Stationaries" },
                new Sales  { Id = 6, CategoryName = "Fruits" },
                new Sales  { Id = 8, CategoryName = "Drinks" },
                new Sales  { Id = 10, CategoryName = "Beverages" },
                new Sales  { Id = 12, CategoryName = "Flours" },
            };
        }
    }


    public class Items
    {
        public int RollNumber { get; set; }
        public string ItemName { get; set; }
        public int Amount { get; set; }
        public int SalesId { get; set; }

        public static List<Items> GetItems()
        {
            return new List<Items>
            {
                new Items { RollNumber = 10, ItemName = "Books", Amount = 500, SalesId = 2 },
                 new Items { RollNumber = 20, ItemName = "Bottled Fants", Amount = 150, SalesId = 8 },
                  new Items { RollNumber = 30, ItemName = "Apple", Amount = 200, SalesId = 6 },
                   new Items { RollNumber = 40, ItemName = "Bread", Amount = 650, SalesId = 12 },
                   new Items { RollNumber = 60, ItemName = "Milo", Amount = 1000, SalesId = 10 },
                    new Items { RollNumber = 80, ItemName = "Pencil", Amount = 500, SalesId = 2 },
                     new Items { RollNumber = 2, ItemName = "Sans", Amount = 250, SalesId = 8},
                      new Items { RollNumber = 3, ItemName = "Pineapple", Amount = 2200, SalesId = 6 },
                       new Items { RollNumber = 5, ItemName = "Rice", Amount = 5050, SalesId = 12 },
                        new Items { RollNumber = 4, ItemName = "Cocoa", Amount = 1000, SalesId = 10 },
            };
        }






    }
}
