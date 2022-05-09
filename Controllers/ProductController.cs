using Ecommerce.Contracts;
using Ecommerce.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILatestNewsRepository _latestNewsService;
        private static int _productId;
        public ProductController(IProductService productService, ILatestNewsRepository latestNewsService)
        {
            _productService = productService;
            _latestNewsService = latestNewsService;
        }
        public IActionResult Index(int id)
        {
            if(id > 0)
            {
                _productId = id;
            }
            UserProductViewModel userProductViewModel = new UserProductViewModel();
            userProductViewModel.Product =  _productService.GetProductById(_productId);
            userProductViewModel.Products =  _productService.GetAllProducts();
            return View(userProductViewModel);
        }
       
    }
}
