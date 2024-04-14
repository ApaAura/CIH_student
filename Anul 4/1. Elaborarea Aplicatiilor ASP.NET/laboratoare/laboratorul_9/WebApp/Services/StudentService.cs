using WebApp.Data;
using WebApp.Models;

namespace WebApp.Services
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
        //Să se afișeze lista elevilor restanțieri;
        public List<Student> Restantieri()
        {
            return _appDbContext.Students.Where(x => x.Media < 5).ToList();
        }
        //Să se afișeze lista elevilor cu media mai mare ca 7.50;
        public List<Student> Bursieri()
        {
            return _appDbContext.Students.Where(x => x.Media >= 7.5).ToList();
        }
        //Să se afișeze lista fetelor;
        public List<Student> Fete()
        {
            return _appDbContext.Students.Where(x => x.Sex == "Female").ToList();
        }
        //Să se afișeze lista băeților ce au note mai mari ca 8.00
        public List<Student> BaietiBursieri()
        {
            return _appDbContext.Students.Where(x => x.Sex == "Male"&& x.Media >= 8).ToList();
        }
        //Să se afișeze lista elevilor ce au vârsta mai mare de 20 ani
        public List<Student> Varsta()
        {
            return _appDbContext.Students.Where(x => x.DataNasterii != null && DateTime.Now.Year - x.DataNasterii.Value.Year >= 20).ToList();
        }
        //sort A-Z
        public List<Student> AZ()
        {
            return _appDbContext.Students.OrderBy(s => s.Nume).ToList();
        }
        //sort Z-A
        public List<Student> ZA()
        {
            return _appDbContext.Students.OrderByDescending(s => s.Nume).ToList();
        }
        //sort cresc by nota
        public List<Student> BigestGrade()
        {
            return _appDbContext.Students.OrderBy(s => s.Media).ToList();
        }
        //sort desccresc by nota
        public List<Student> SmallestGrade()
        {
            return _appDbContext.Students.OrderByDescending(s => s.Media).ToList();
        }
    }
}
