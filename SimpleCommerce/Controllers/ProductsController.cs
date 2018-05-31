using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleCommerce.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCommerce.Controllers
{
    public class ProductsController : ControllerBase { 
    public ProductsController(ApplicationDbContext context) : base(context)
    {


    }
        public IActionResult Index(int CategoryId)
        {
            ViewBag.ProductsCategories = _context.Categories.Include(c =>c.Products).ToList();
            ViewBag.SelectedCategory = _context.Categories.Where(c => c.Id == CategoryId).FirstOrDefault();
            ViewBag.LatestProduct = _context.Products.OrderByDescending(o => o.CreateDate).Take(3).ToList();
            return View();
        }

    }
    
}
