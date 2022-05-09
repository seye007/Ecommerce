using Ecommerce.Contracts;
using Ecommerce.Models;
using Ecommerce.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<Product> GetAllProducts()
        {
            try
            {
                List<Product> products = _productRepository.GetAllProductsFromDb();
                return products;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Product GetProductById(int id)
        {
            try
            {
                Product product = _productRepository.GetAProductFromDb(id);
                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
