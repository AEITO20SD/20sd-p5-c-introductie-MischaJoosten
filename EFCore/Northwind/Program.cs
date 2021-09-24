using Microsoft.EntityFrameworkCore;
using Northwind.Data;
using System;
using System.Linq;

namespace Northwind
{
    class Program
    {
        private static string _connectionsString = @"Server=(localdb)\MSSQLLocalDB;Database=Northwind";

        private static void ShowCategories()
        {
            var db = new NorthwindDbContext(_connectionsString);
            var categories = db.Categories.ToList();
            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryID}: {category.CategoryName}");
            }
        }

        private static void ShowProductsBySupplier(int supID)
        {
            var db = new NorthwindDbContext(_connectionsString);
            var products = db.Products
            .Where(a => a.SupplierID == supID)
            .Include(a => a.Category)
            .Include(a => a.Supplier)
            .ToList();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductID}: {product.ProductName}, {product.Supplier.CompanyName}, {product.Category.CategoryName}");
            }
        }

        private static void ShowSuppliers()
        {
            var db = new NorthwindDbContext(_connectionsString);
            var suppliers = db.Suppliers.ToList();

            foreach (var supplier in suppliers)
            {
                Console.WriteLine($"{supplier.SupplierID}: {supplier.CompanyName}");
            }
        }
        static void Main(string[] args)
        {
            ShowSuppliers();
            Console.WriteLine("Kies een supplier");
            var SupID = Console.ReadLine();
            int supID;
            int.TryParse(SupID, out supID);
            ShowProductsBySupplier(supID);
        }
    }
}
