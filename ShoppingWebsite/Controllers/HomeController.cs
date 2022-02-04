using Microsoft.AspNetCore.Mvc;
using ShoppingWebsite.Data;
using ShoppingWebsite.Models;
using System.Diagnostics;

namespace ShoppingWebsite.Controllers
{
    public class HomeController : ApplicationController
    {
        private readonly ILogger<ApplicationController> _logger;

        public HomeController(ApplicationContext context, IHttpContextAccessor httpContextAccessor, ILogger<ApplicationController> logger)
            : base(context, httpContextAccessor, logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Products");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}