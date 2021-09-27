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
    public class SuppliersModel : PageModel
    {
        private readonly NorthwindDbContext _context;
        
        public List<Supplier> Suppliers { get; set; }

        public SuppliersModel(NorthwindDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            ViewData["Title"] = "Suppliers";

            Suppliers = _context.Suppliers.ToList();
        }
    }
}
