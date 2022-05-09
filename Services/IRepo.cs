﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public interface IRepo<T> where T : class
    {
            Task<List<T>> GetRecord();
            Task<bool> Insert(T entity);
            bool Update(T entity);
            bool Delete(T entity);
    }
}
