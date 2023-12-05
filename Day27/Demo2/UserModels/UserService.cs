
namespace Demo2.UserModels
{
    public class UserService
    {
        public List<User> GetUsers()
        {
            Console.WriteLine("Loading users...");
            return new List<User>(){
                new User() {Name = "John", Email = "John@example.com", Phone = "123"},
                new User() {Name = "Jane", Email = "Jane@example.com", Phone = "456"},
            };
        }
    }
}