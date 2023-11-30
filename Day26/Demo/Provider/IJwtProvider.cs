using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Identity;

namespace Demo.Provider
{
    public interface IJwtProvider
    {
        string GenerateToken(User user);
    }
}