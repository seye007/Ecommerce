using Ecommerce.Contracts;
using Ecommerce.Models;
using Ecommerce.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
       
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        private static List<User> userDB = new List<User>();
        public async Task<bool> AddUser(User model)
        {
            try
            {
               await _userRepository.AddUserToDb(model);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }
        public  List<User> GetAllUsers()
        {
            try
            {
                List<User> users = _userRepository.GetAllUsersFromDb();
                return users;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
