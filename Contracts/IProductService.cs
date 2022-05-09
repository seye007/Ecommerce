using Ecommerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Contracts
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
