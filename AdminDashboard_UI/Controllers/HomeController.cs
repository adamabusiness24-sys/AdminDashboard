using System.Diagnostics;
using AdminDashboard_UI;
using AdminDashboard_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminDashboard_UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext _context;
        public HomeController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            var data = _context.Products.ToList();
            return View(data);
        }
        public IActionResult PasswordIncorrect()
        {
            return View();
        }
        public IActionResult UserNotFound()
        {
            return View();
        }
        public IActionResult existingUserFound()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrationUser(string username, string email, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                //ModelState.AddModelError("ConfirmPassword", "Passwords do not match.");
                return View("PasswordIncorrect");
            }
            var existingUser = _context.Users.FirstOrDefault(u => u.Name == username || u.Email == email);
            if(existingUser != null)
            {
                return View("existingUserFound");
            }
            _context.Users.Add(new Users
            {
                Name = username,
                Email = email,
                Password = password,
                Role = "User"
            }); 
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Name == username);
            if (user == null)
            {
                return View("UserNotFound");
            }
            if (user.Password != password)
            {
                return View("UserNotFound");
            } 
            return RedirectToAction("Dashboard");
        }
    }

}
