using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Northwind.Data;
using Northwind.Models;

namespace RazorPages.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly NorthwindDbContext _context;

        public List<Product> Products { get; set; }
        public List<Category> Categories { get; private set; }
        public List<Supplier> Suppliers { get; private set; }

        public ProductsModel(NorthwindDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            ViewData["Title"] = "Products";

            Products = _context.Products
                .OrderBy(Product => Product.ProductName)
                .ToList();
            Categories = _context.Categories.ToList();
            Suppliers = _context.Suppliers.ToList();
        }
    }
}
