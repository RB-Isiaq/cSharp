
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Demo.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Demo.Provider
{
    public class JwtProvider : IJwtProvider
    {
        JwtOptions _options;
        public JwtProvider(IOptions<JwtOptions> options)
        {
            _options = options.Value;
            Console.WriteLine("SigningKey: " + _options.SigningKey);
            Console.WriteLine("Audience: " + _options.Audience);
            Console.WriteLine("Issuer: " + _options.Issuer);
        }
        public string GenerateToken(User user)
        {
            if (!string.IsNullOrEmpty(user.Email)
                && !string.IsNullOrEmpty(user.FirstName)
                && !string.IsNullOrEmpty(user.Role))
            {
                var claims = new Claim[]
                {
                new(ClaimTypes.Email, user.Email),
                new(ClaimTypes.Name, user.FirstName),
                new(ClaimTypes.Role, user.Role),
                };

                var SigningKey = new SigningCredentials(
                    new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(_options?.SigningKey ?? string.Empty)),
                        SecurityAlgorithms.HmacSha256);


                var token = new JwtSecurityToken(
                     _options?.Issuer,
                     _options?.Audience,
                     claims,
                     null,
                     DateTime.UtcNow.AddHours(2),
                     SigningKey
                );

                string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
                Console.WriteLine(tokenValue);

                return tokenValue;
            }
            else return string.Empty;
        }
    }
}