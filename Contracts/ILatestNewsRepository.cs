using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Contracts
{
    public interface ILatestNewsRepository
    {
        public List<News> GetAllLatestNewsromDb();
    }
}
