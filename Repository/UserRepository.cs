using Ecommerce.Contracts;
using Ecommerce.Infrastructure;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbConext)
        {
            _dbContext = dbConext;  
        }
        public async Task<bool> AddUserToDb(User model)
        {
            try
            {
                await _dbContext.AddAsync(model);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<User> GetAllUsersFromDb()
        {
           return _dbContext.Users.ToList();
        }
        public User GetAUserFromDb(int id)
        {
            return  _dbContext.Users.Where(x => x.Id == id).FirstOrDefault();
        }
        public async Task<bool> UpdateAUserInDb(User model)
        {
            try
            {
                 _dbContext.Update(model);
                 await _dbContext.SaveChangesAsync();
                 return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
