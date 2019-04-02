using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _appDbContext;

        public UserService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<User> GetAllUsers()
        {

            return _appDbContext.Users;
        }

        public User GetUserById(int id)
        {
            return _appDbContext.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
