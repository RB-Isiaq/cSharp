
using Demo.Identity;
using Demo.Interfaces;

namespace Demo.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users;
        public UserService()
        {
            _users = UserDb.users;
        }
        public User GetUser(string username)
        {
            return _users.First(m => m.UserName == username);
        }

        public bool IsCredentialsValid(string username, string password)
        {
            return _users.Any(m => m.UserName == username && m.Password == password);
        }
    }
}