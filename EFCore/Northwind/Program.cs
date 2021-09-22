using Microsoft.EntityFrameworkCore;
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

        private static void ToonProducts(int catID)
        {
            var db = new NorthwindDbContext(_connectionsString);
            var products = db.Products
            .Where(a => a.CategoryID == catID)
            .Include(a => a.Category)
            .ToList();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductID}: ");
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Category.CategoryName);
                Console.WriteLine(product.UnitPrice);
            }
        }
        static void Main(string[] args)
        {
            ToonCategories();
            Console.WriteLine("Kies een category");
            var CatID = Console.ReadLine();
            int catID;
            int.TryParse(CatID, out catID);
            ToonProducts(catID);
        }
    }
}
