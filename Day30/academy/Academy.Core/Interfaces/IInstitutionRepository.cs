
using Academy.Core.Entities;

namespace Academy.Core.Interfaces
{
    public interface IInstitutionRepository
    {
        Task<Institution> Add(Institution institution);
        Task<Institution> Update(Institution institution);
        Task<Institution> GetById(Guid institutionId);
        Task<List<Institution>> GetAll();
        Task<bool> Delete(Guid institutionId);
    }
}