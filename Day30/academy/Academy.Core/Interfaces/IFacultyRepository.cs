
using Academy.Core.Entities;

namespace Academy.Core.Interfaces
{
    public interface IFacultyRepository
    {
        Task<Faculty> Add(Faculty faculty);
        Task<Faculty> Update(Faculty faculty);
        Task<Faculty> Get(Guid facultyId);
        Task<List<Faculty>> GetAll();
        Task<bool> Delete(Guid facultyId);
    }
}