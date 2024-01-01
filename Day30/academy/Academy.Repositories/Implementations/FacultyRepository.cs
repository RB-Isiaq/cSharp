
using Academy.Core.Entities;
using Academy.Core.Interfaces;
using Academy.Repositories.Data;

namespace Academy.Repositories.Implementations
{
    public class FacultyRepository : IFacultyRepository
    {
        private AcademyContext _academicContext;
        public FacultyRepository(AcademyContext academyContext)
        {
            _academicContext = academyContext;
        }
        public async Task<Faculty> Add(Faculty faculty)
        {
            _academicContext.Add(faculty);
            _academicContext.SaveChanges();
            return await Task.FromResult(faculty);

        }

        public async Task<bool> Delete(Guid facultyId)
        {
            var faculty = await Task.FromResult(_academicContext.Faculties.Where(m => m.Id == facultyId).First());
            _academicContext.Faculties.Remove(faculty);
            _academicContext.SaveChanges();
            return _academicContext.SaveChanges() > 0;
        }

        public async Task<Faculty> Get(Guid facultyId)
        {
            var faculty = await Task.FromResult(_academicContext.Faculties.Where(m => m.Id == facultyId).First());
            return faculty;
        }

        public Task<List<Faculty>> GetAll()
        {
            return Task.FromResult(_academicContext.Faculties.ToList());
        }

        public async Task<Faculty> Update(Faculty faculty)
        {
            var update = _academicContext.Faculties.Update(faculty);
            _academicContext.SaveChanges();
            Console.WriteLine(update);
            return await Task.FromResult(faculty);
        }
    }
}