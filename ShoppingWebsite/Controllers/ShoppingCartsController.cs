using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingWebsite.Data;
using ShoppingWebsite.Models;
using ShoppingWebsite.Services;

namespace ShoppingWebsite.Controllers
{
    public class ShoppingCartsController : ApplicationController
    {
        private readonly ApplicationContext _context;

        public ShoppingCartsController(ApplicationContext context, IHttpContextAccessor httpContextAccessor, ILogger<ApplicationController> logger)
              : base(context, httpContextAccessor, logger)
        {
            _context = context;
        }

        // GET: ShoppingCarts
        public async Task<IActionResult> Index()
        {
            List<Product> products = HttpContext.Session.Get<List<Product>>("products");
            return View(products);
        }

        // GET: ShoppingCarts/Details/5
        public async Task<IActionResult> Add(int? id)
        {

            List<Product> products = HttpContext.Session.Get<List<Product>>("products");
            var product = await _context.Product.FirstOrDefaultAsync(i => i.Id == id);
            if (products == null)
            {
                products = new List<Product>();

                products.Add(product);
                HttpContext.Session.Set("products", products);
            }
            else
            {

                products.Add(product);
                HttpContext.Session.Set("products", products);
            }




            return RedirectToAction("Index", "Products");
        }
        public async Task<IActionResult> Remove(int? id)
        {

            List<Product> products = HttpContext.Session.Get<List<Product>>("products");
            int index = -1;
            if(products != null)
            {
                foreach (var item in products)
                {
                    if(item.Id == id)
                    {
                        index = products.IndexOf(item);
                    }
                }
                products.RemoveAt(index);
                HttpContext.Session.Set("products", products);
            }

            





            return RedirectToAction("Index");
        }

        // GET: ShoppingCarts/Create
    }
}
