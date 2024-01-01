
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
        public async Task<Institution> Add(Institution institution)
        {
            _academicContext.Add(institution);
            _academicContext.SaveChanges();
            return await Task.FromResult(institution);
        }

        public async Task<bool> Delete(Guid institutionId)
        {
            var institution = await Task.FromResult(_academicContext.Institutions.Where(i => i.Id == institutionId).First());
            _academicContext.Remove(institution);
            _academicContext.SaveChanges();
            return _academicContext.SaveChanges() > 0; // it return a number, if it's greater than 0, return true
        }

        public async Task<Institution> GetById(Guid institutionId)
        {
            var institution = await Task.FromResult(_academicContext.Institutions.Where(i => i.Id == institutionId).First());
            return institution;
        }

        public async Task<List<Institution>> GetAll()
        {

            return await Task.FromResult(_academicContext.Institutions.ToList());
        }

        public async Task<Institution> Update(Institution institution)
        {
            var update = _academicContext.Institutions.Update(institution);
            _academicContext.SaveChanges();
            Console.WriteLine(update);
            return await Task.FromResult(institution);
        }
    }
}