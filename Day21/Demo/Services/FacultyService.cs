
using Demo.Interfaces;
using Demo.Models;

namespace Demo.Services
{
    public class FacultyService : IFacultyService
    {
        private readonly static List<Faculty> faculties = new List<Faculty>
        {
            new Faculty()
            {
                Id= 1,
                Name= "Unilorin"
            },
            new Faculty()
            {
                Id= 2,
                Name= "UI"
            },
            new Faculty()
            {
                Id= 3,
                Name= "Unilag"
            }
        };
        public void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }
        public void DeleteFaculty(int facultyId)
        {
            Faculty? faculty = faculties.Where(m => m.Id == facultyId).SingleOrDefault();
            faculties.Remove(faculty ?? new Faculty());
        }
        public Faculty GetFacultyById(int facultyId)
        {
            Faculty? faculty = faculties.Where(m => m.Id == facultyId).SingleOrDefault();
            return faculty ?? new Faculty();
        }
        public List<Faculty> GetFaculties()
        {
            return faculties;
        }
        public void UpdateFaculty(Faculty newFaculty)
        {
            Faculty? faculty = faculties.Where(m => m.Id == newFaculty.Id).SingleOrDefault();

            foreach (Faculty fac in faculties)
            {
                if (fac.Id == newFaculty.Id)
                {
                    fac.Name = newFaculty.Name;
                }
            }
        }
    }
}