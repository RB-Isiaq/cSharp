
using Academy.Core.Entities;
using Academy.Core.Interfaces;
using Academy.Repositories.Data;

namespace Academy.Repositories.Implementations
{
    public class InstitutionRepository : IInstitutionRepository
    {
        private AcademyContext _academicContext;
        public InstitutionRepository(AcademyContext academyContext)
        {
            _academicContext = academyContext;
        }
        public Task<Institution> Add(Institution institution)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid institutionId)
        {
            throw new NotImplementedException();
        }

        public Task<Institution> Get(Guid institutionId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Institution>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Institution> Update(Institution institution)
        {
            throw new NotImplementedException();
        }
    }
}