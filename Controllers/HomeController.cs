using Ecommerce.Contracts;
using Ecommerce.Models;
using Ecommerce.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly ILatestNewsRepository _latestNewsService;
        public HomeController(ILogger<HomeController> logger, IProductService productService, ILatestNewsRepository latestNewsService)
        {
            _logger = logger;
            _productService = productService;
            _latestNewsService = latestNewsService;
        }
        public IActionResult Index(UserProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                productViewModel.Products =  _productService.GetAllProducts();
                productViewModel.LatestNews = _latestNewsService.GetAllLatestNewsromDb();
                return View(productViewModel);
            }
            return View(productViewModel);
        }     
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult LoadMore(int page=1)
        {
            UserProductViewModel productViewModel = new UserProductViewModel();
            productViewModel.Products = _productService.GetAllProducts();
            productViewModel.IsSuccess = true;
            productViewModel.ProductPerPage = 5;
            productViewModel.CurrentPage = page;
            return View(productViewModel);
        }

        public IActionResult LoadMore2(int page = 1)
        {
            UserProductViewModel productViewModel = new UserProductViewModel();
            productViewModel.Products = _productService.GetAllProducts();
            productViewModel.IsSuccess = true;
            productViewModel.ProductPerPage = 5;
            productViewModel.CurrentPage = page;
            return View(productViewModel);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
