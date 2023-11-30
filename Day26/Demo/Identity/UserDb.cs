using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Identity
{
    public class UserDb
    {
        public static List<User> users = new List<User>{
            new User()
            {
                Email = "test@example.com",
                FirstName = "John",
                UserName = "test",
                Password = "password"
            },
            new User()
            {
                Email = "test@test.com",
                FirstName = "Doe",
                UserName = "doe",
                Password = "passwordD"
            },
        };
    }
}