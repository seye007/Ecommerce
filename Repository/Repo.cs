using Ecommerce.Infrastructure;
using Ecommerce.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class Repo<T> : IRepo<T> where T : class
    {
            private readonly ApplicationDbContext _dbContext;
            private readonly DbSet<T> _dbSet;
            public Repo(ApplicationDbContext dbContext, DbSet<T> dbSet)
            {
                _dbContext = dbContext;
                _dbSet = _dbContext.Set<T>();
            }

            public async Task<List<T>> GetRecord()
            {
                return await _dbSet.ToListAsync();
            }

            public bool Delete(T entity)
            {
                try
                {
                    if (entity != null)
                    {
                        _dbSet.Remove(entity);
                        _dbContext.SaveChanges();

                    }
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public async Task<bool> Insert(T entity)
            {
                try
                {
                    await _dbSet.AddAsync(entity);
                    _dbContext.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public bool Update(T entity)
            {

                try
                {
                    _dbSet.Update(entity);
                    _dbContext.SaveChanges();
                    return true;
                }

                catch (Exception)
                {

                    throw;
                }
            }
    }
 }