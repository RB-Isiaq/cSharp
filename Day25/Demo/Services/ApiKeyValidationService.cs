
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
            if (string.IsNullOrEmpty(userApiKey))
            {
                return false;
            }
            var key = _configuration
            .GetValue<string>(Constants.AppConstants.ApiKeyName);

            if (key == userApiKey)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}