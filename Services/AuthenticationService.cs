using Ecommerce.Contracts;
using Ecommerce.Models;
using Ecommerce.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    internal class AuthenticationService : IAuthentication
    {
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> Login(string email, string password)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    List<User> users = _userRepository.GetAllUsersFromDb();
                    User user = null;
                    user = users.FirstOrDefault(x => x.Email == email && x.Password == password);
                    return user;
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
            return null;
        }
            
    }
}

