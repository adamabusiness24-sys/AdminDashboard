using AdminDashboard_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminDashboard_UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDBContext _context;
        public ProductController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProductItem(string productname, string description, decimal price, string color)
        {
            var newProduct = new Products
            {
                ProductName = productname,
                Description = description,
                Price = price,
                color = color
            };
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("Dashboard", "Home");
        }
    }
}
