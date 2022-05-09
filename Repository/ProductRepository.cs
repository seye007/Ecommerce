using Ecommerce.Contracts;
using Ecommerce.Infrastructure;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductRepository(ApplicationDbContext dbConext)
        {
            _dbContext = dbConext;
        }
        public List<Product> GetAllProductsFromDb()
        {
            return _dbContext.Products.ToList();
        }
        public Product GetAProductFromDb(int id)
        {
            return _dbContext.Products.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
