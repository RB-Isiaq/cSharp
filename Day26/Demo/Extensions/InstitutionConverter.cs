
using Demo.Dtos.Institutions;
using Demo.Models;

namespace Demo.Extensions
{
    public static class InstitutionConverter
    {
        public static GetInstittutionDto InstitutionToGetInstitutionDto(this Institution institution)
        {
            return new GetInstittutionDto()
            {
                City = institution.City,
                Name = institution.Name,
                Id = institution.Id
            };
        }
    }
}