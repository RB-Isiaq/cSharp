
using Demo.Interfaces;

namespace Demo.Services
{
    public class ApiKeyValidationService : IApiKeyValidationService
    {
        private readonly IConfiguration _configuration;
        public ApiKeyValidationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public bool IsValidApiKey(string userApiKey)
        {
            var key = _configuration
            .GetValue<string>(Constants.AppConstants.ApiKeyName);

            return Convert.ToBoolean(key == userApiKey);
        }
    }
}