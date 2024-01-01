

using System.Collections.Generic;
using Academy.Services.Contracts.Institutions;

namespace Academy.Services.Interfaces
{
    public interface IInstitutionService
    {
        InstitutionCreateRes<InstitutionDto> CreateInstitution(InstitutionCreateReq req);
        InstitutionUpdateRes UpdateInstitution(InstitutionUpdateReq req);
        InstitutionResponses<InstitutionDto> GetById(Guid institutionId);
        InstitutionResponses<List<InstitutionDto>> GetById();
    }
};