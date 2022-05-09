using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Contracts
{
    public interface IProductRepository
    {
        List<Product> GetAllProductsFromDb();
        Product GetAProductFromDb(int id);
    }
}
