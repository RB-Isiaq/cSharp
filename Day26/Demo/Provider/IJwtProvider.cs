
using Demo.Identity;

namespace Demo.Provider
{
    public interface IJwtProvider
    {
        string GenerateToken(User user);
    }
}