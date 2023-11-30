using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    public interface IApiKeyValidationService
    {
        bool IsValidApiKey(string userApiKey);
    }
}