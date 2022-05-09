using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Contracts
{
    public interface ILatestNewsService
    {
        List<News> GetAllLatestNews();
    }
}
