using Ecommerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Contracts
{    public interface IUserRepository
    {
        Task<bool> AddUserToDb(User model);
        List<User> GetAllUsersFromDb();
        public User GetAUserFromDb(int id);
    }
    
}
