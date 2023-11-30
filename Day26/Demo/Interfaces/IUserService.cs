using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Identity;

namespace Demo.Interfaces
{
    public interface IUserService
    {
        bool IsCredentialsValid(string username, string password);
        User GetUser(string username);
    }
}