
using Academy.Core.Entities;
using Academy.Services.Contracts.Institutions;

namespace Academy.Services.Extension
{
    public static class InstitutionEtension
    {
        public static Institution ToEntity(this InstitutionCreateReq dto)
        {
            return new Institution
            {
                City = dto.City,
                Country = dto.Country,
                CreatedBy = "Ridwan",
                DateCreated = DateTime.UtcNow
            };
        }
    }
}