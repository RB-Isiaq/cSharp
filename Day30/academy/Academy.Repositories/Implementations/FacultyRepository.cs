
using Academy.Core.Entities;
using Academy.Core.Interfaces;

namespace Academy.Repositories.Implementations
{
    public class FacultyRepository : IFacultyRepository
    {
        public Task<Faculty> Add(Faculty faculty)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid facultyId)
        {
            throw new NotImplementedException();
        }

        public Task<Faculty> Get(Guid facultyId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Faculty>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Faculty> Update(Faculty faculty)
        {
            throw new NotImplementedException();
        }
    }
}