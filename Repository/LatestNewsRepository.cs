using Ecommerce.Contracts;
using Ecommerce.Infrastructure;
using Ecommerce.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Repository
{
    public class LatestNewsRepository : ILatestNewsRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public LatestNewsRepository(ApplicationDbContext dbConext)
        {
            _dbContext = dbConext;
        }
        public List<News> GetAllLatestNewsromDb()
        {
            return _dbContext.News.ToList();
        }

    }
}
