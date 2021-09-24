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

        private static void ShowProductsByOutput(int catID, int supID)
        {
            var db = new NorthwindDbContext(_connectionsString);
            var products = db.Products
            .Where(a => a.CategoryID == catID)
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

        private static int ShowOrderID()
        {
            var db = new NorthwindDbContext(_connectionsString);
            Console.WriteLine("Voer een OrderID in");
            var orderId = Console.ReadLine();
            int OrderId;
            int.TryParse(orderId, out OrderId);
            if (db.Orders.Any(u => u.OrderID == OrderId))
            {
                Console.WriteLine("Bestaat");
                return OrderId;
            }
            else
            {
                Console.WriteLine("Die OrderID bestaat niet.");
                ShowOrderID();
            }
            return OrderId;
        }

        private static void ShowOrder(int OrderId)

        {
            Console.Clear();
            OrderHeader(OrderId);
            OrderDetails(OrderId);
        }

        private static void OrderHeader(int OrderId)
        {
            var db = new NorthwindDbContext(_connectionsString);
            var orders = db.Orders
            .Where(a => a.OrderID == OrderId)
            .Include(a => a.Customer)
            .ToList();
            foreach (var order in orders)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(order.Customer.CompanyName);
                Console.WriteLine(order.Customer.ContactName);
                Console.WriteLine(order.Customer.Address);
                Console.WriteLine(order.Customer.City);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Order: {order.OrderID}  Date:");
                DateTime? dateAndTime = order.OrderDate;
                Console.WriteLine(dateAndTime.Value.ToString("dd/MM/yyyy"));
                Console.WriteLine();
            }
        }

        private static void OrderDetails(int OrderId)
        {
            var db = new NorthwindDbContext(_connectionsString);
            var orderdetails = db.OrderDetails
            .Where(a => a.OrderID == OrderId)
            .Include(a => a.Product)
                .ThenInclude(a => a.Category)
            .ToList();
            string output;
                            string header = String.Format("{0,-18}{1,40}{2,15}{3,10}{4,15}\n",
                                    "Category", "Product", "UnitPrice", "Quantity", "Total");
                Console.WriteLine(header);

            foreach (var OrderDetail in orderdetails)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.ForegroundColor = ConsoleColor.Yellow;
                decimal UnitRond = OrderDetail.UnitPrice;
                decimal mathrounded = Math.Round(UnitRond, 2);
                string unitprice = "€" + mathrounded;
                decimal Total = OrderDetail.Quantity * OrderDetail.UnitPrice;
                decimal TotalRoundedEuro = (Math.Round(Total, 2));
                string RondEuro = "€ " + TotalRoundedEuro;

                output = String.Format("{0,-18}{1,40}{2,15}{3,10}{4,15}",
                                OrderDetail.Product.Category.CategoryName, OrderDetail.Product.ProductName, unitprice, OrderDetail.Quantity, RondEuro);
                Console.WriteLine(output);
            }
        }

        static void Main(string[] args)
        {
            //int supID;
            //int catID;

            //ShowCategories();
            //Console.WriteLine("Kies een Category");
            //var CatID = Console.ReadLine();
            //int.TryParse(CatID, out catID);
            //ShowProductsByOutput(catID, supID);

            //ShowSuppliers();
            //Console.WriteLine("Kies een Supplier");
            //var SupID = Console.ReadLine();
            //int.TryParse(SupID, out supID);
            //ShowProductsByOutput(catID, supID);


            int orderID = ShowOrderID();
            ShowOrder(orderID);
        }
    }
}
