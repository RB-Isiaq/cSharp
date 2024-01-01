using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Core.Interfaces;
using Academy.Services.Contracts.Institutions;
using Academy.Services.Extension;
using Academy.Services.Interfaces;

namespace Academy.Services.Implementations
{
    public class InstitutionService : IInstitutionService
    {
        private readonly IInstitutionRepository _repository;
        public InstitutionService(IInstitutionRepository repository)
        {
            _repository = repository;
        }
        public InstitutionCreateRes<InstitutionDto> CreateInstitution(InstitutionCreateReq req)
        {
            var newInstitution = req.ToEntity();
            _repository.Add(newInstitution);
            return new InstitutionCreateRes<InstitutionDto>
            {
                Code = "200",
                Message = string.Empty
            };
        }

        public InstitutionResponses<InstitutionDto> GetById(Guid institutionId)
        {
            throw new NotImplementedException();
        }

        public InstitutionResponses<List<InstitutionDto>> GetById()
        {
            throw new NotImplementedException();
        }

        public InstitutionUpdateRes UpdateInstitution(InstitutionUpdateReq req)
        {
            throw new NotImplementedException();
        }
    }
}