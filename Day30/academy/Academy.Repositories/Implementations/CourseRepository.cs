
using Academy.Core.Entities;
using Academy.Core.Interfaces;

namespace Academy.Repositories.Implementations
{
    public class CourseRepository : ICourseRepository
    {
        public Task<Course> Add(Course course)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid courseId)
        {
            throw new NotImplementedException();
        }

        public Task<Course> Get(Guid courseId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Course>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Course> Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}