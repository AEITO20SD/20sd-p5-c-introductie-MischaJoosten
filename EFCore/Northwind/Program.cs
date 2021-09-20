using Northwind.Data;
using System;
using System.Linq;

namespace Northwind
{
    class Program
    {
        private static string _connectionsString = @"Server=(localdb)\MSSQLLocalDB;Database=Northwind";

        private static void ToonCategories()
        {
            var db = new NorthwindDbContext(_connectionsString);
            var categories = db.Categories.ToList();
            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryID}: ");
                Console.WriteLine(category.CategoryName);
            }
        }
        static void Main(string[] args)
        {
            ToonCategories();
        }
    }
}
