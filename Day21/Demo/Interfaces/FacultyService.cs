using Demo.Models;

namespace Demo.Interfaces
{
    public interface FacultyService
    {
        void AddFaculty(Faculty faculty);
        List<Faculty> GetFaculties();
        Faculty GetFacultyById(int facultyId);
        void UpdateFaculty(Faculty faculty);
        void DeleteFaculty(int facultyId);

    }
}