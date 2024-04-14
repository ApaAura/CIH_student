using StudentApp.Data;
using StudentApp.Models;

namespace StudentApp.Services
{
    public class StudentService
    {
        private AppDbContext _appDbContext;
        public StudentService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // Create a new student
        public void CreateStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            _appDbContext.Students.Add(student);
            _appDbContext.SaveChanges();
        }

        // Get all students
        public List<Student> GetAllStudents()
        {
            return _appDbContext.Students.ToList();
        }

        // Get student by ID
        public Student GetStudentById(int id)
        {
            return _appDbContext.Students.FirstOrDefault(s => s.ID == id)!;
        }

        // Update an existing student
        public void UpdateStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            _appDbContext.Students.Update(student);
            _appDbContext.SaveChanges();
        }

        // Delete a student by ID
        public void DeleteStudent(int id)
        {
            var student = _appDbContext.Students.FirstOrDefault(s => s.ID == id);
            if (student != null)
            {
                _appDbContext.Students.Remove(student);
                _appDbContext.SaveChanges();
            }
        }
        public List<Student> Restantieri()
        {
            return _appDbContext.Students.Where(x => x.Nota < 5).ToList();
        }
        public List<Student> Bursieri()
        {
            return _appDbContext.Students.Where(x => x.Nota >= 7 ).ToList();
        }
    }
}
