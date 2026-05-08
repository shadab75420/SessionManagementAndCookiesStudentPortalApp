using Microsoft.AspNetCore.Mvc;

namespace StudentPortalApp.Controllers
{
    public class AccountController : Controller
    {
        // Login Page
        public IActionResult Login()
        {
            return View();
        }

        // Handle Login
        [HttpPost]
        public IActionResult Login(string username)
        {
            // US-201: Store Session
            HttpContext.Session.SetString("User", username);

            return RedirectToAction("Dashboard");
        }

        // Dashboard
        public IActionResult Dashboard()
        {
            // Read Session
            var user = HttpContext.Session.GetString("User");

            // US-203: Block Unauthorized Users
            if (string.IsNullOrEmpty(user))
            {
                return RedirectToAction("Login");
            }

            // US-202: Store Cookie
            Response.Cookies.Append("Theme", "Dark");

            // Read Cookie
            var theme = Request.Cookies["Theme"];

            // Send Data to View
            ViewBag.Username = user;
            ViewBag.Theme = theme;

            return View();
        }

        // Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}