
using Demo.Dtos.Auth;
using Demo.Identity;
using Demo.Interfaces;
using Demo.Provider;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly IUserService _usersService;

        public AuthController(IJwtProvider jwtProvider, IUserService userService)
        {
            _jwtProvider = jwtProvider;
            _usersService = userService;
        }

        [HttpPost]
        [Route("auth")]
        public ActionResult<string> Authenticate([FromBody] AuthenticateRequest request)
        {
            var user = new User
            {
                UserName = request.UserName,
                Password = request.Password
            };

            var result = _usersService
                        .IsCredentialsValid(
                         user?.UserName ?? string.Empty,
                         user?.Password ?? string.Empty);

            if (!result)
            {
                return Unauthorized();
            }

            var authenticatedUser = _usersService.GetUser(user?.UserName ?? string.Empty);

            return _jwtProvider.GenerateToken(authenticatedUser ?? new User());
        }
    }
}