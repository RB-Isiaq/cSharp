using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
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
        }
        public string GenerateToken(User user)
        {
            if (!string.IsNullOrEmpty(user.Email) && !string.IsNullOrEmpty(user.FirstName))
            {
                var claims = new Claim[]
                {
                new(ClaimTypes.Email, user.Email),
                new(ClaimTypes.Name, user.FirstName),
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