using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _appDbContext;// variable used for sending data to DataBase

        public UserService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<User> GetAllUsers()
        {

            return _appDbContext.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _appDbContext.Users.FirstOrDefault(x => x.Id == id);
        }

        public void AddUser(User user)
        {
            _appDbContext.Users.Add(user);
            _appDbContext.SaveChanges();
        }

        public void EditUser(int id, User user)
        {
            var _user = _appDbContext.Users.FirstOrDefault(x => x.Id == id);
            if (_user != null)
            {
                _user.FirstName = user.FirstName;
                _user.LastName = user.LastName;
                _appDbContext.SaveChanges();
            }

        }

        public void DeleteUser(int id)
        {
            var _user = _appDbContext.Users.FirstOrDefault(x => x.Id == id);
            if (_user != null)
            {
                _appDbContext.Remove(_user);
                _appDbContext.SaveChanges();
            }
        }
    }
}
