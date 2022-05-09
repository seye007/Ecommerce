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
    public class LatestNewsService : ILatestNewsService
    {

        private readonly ILatestNewsRepository _connection;

        public LatestNewsService(ILatestNewsRepository connection)
        {
            _connection = connection;
        }
        public List<News> GetAllLatestNews()
        {
                try
                {
                    List<News> latestNews = _connection.GetAllLatestNewsromDb();
                    return latestNews;
                }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
