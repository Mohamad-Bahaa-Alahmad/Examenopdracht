using Microsoft.AspNetCore.Mvc;
using ShoppingWebsite.Areas.Identity.Data;
using ShoppingWebsite.Data;
using ShoppingWebsite.Services;

namespace ShoppingWebsite.Controllers
{
    public class ApplicationController : Controller
    {
        protected readonly ApplicationUser _user;
        protected readonly ApplicationContext _context;
        protected readonly IHttpContextAccessor _httpContextAccessor;
        protected readonly ILogger<ApplicationController> _logger;
        protected readonly IHostEnvironment _hostEnvironment;

        protected ApplicationController(ApplicationContext context,
                                        IHttpContextAccessor httpContextAccessor,
                                        ILogger<ApplicationController> logger)
        {
            _context = context;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            //_user = SessionUser.GetUser(httpContextAccessor.HttpContext.User.Identity.Name);
            //_user = SessionUser.GetUser(httpContextAccessor.HttpContext.User.Identity.Name);
            _user = SessionUser.GetUser(httpContextAccessor.HttpContext);
        }
    }
}
