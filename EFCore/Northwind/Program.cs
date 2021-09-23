﻿using Microsoft.EntityFrameworkCore;
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
                Console.WriteLine($"{category.CategoryID}: {category.CategoryName}");
            }
        }

        private static void ToonProducts(int catID, int supID)
        {
            var db = new NorthwindDbContext(_connectionsString);
            var products = db.Products
            //.Where(a => a.CategoryID == catID)
            .Where(a => a.SupplierID == supID)
            .Include(a => a.Category)
            .Include(a => a.Supplier)
            .ToList();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductID}: {product.ProductName}, {product.Supplier.CompanyName}, {product.Category.CategoryName}");
            }
        }

        private static void ToonSuppliers()
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
            ToonCategories();
            Console.WriteLine("Kies een category");
            var CatID = Console.ReadLine();
            int catID;
            int.TryParse(CatID, out catID);

            ToonSuppliers();
            Console.WriteLine("Kies een supplier");
            var SupID = Console.ReadLine();
            int supID;
            int.TryParse(SupID, out supID);
            ToonProducts(catID, supID);
        }
    }
}
