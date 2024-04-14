using app.Models;

namespace app.Services
{
    public class StudentService
    {
        private List<Student> Students;

        public StudentService()
        {
            Students = new()
            {
                new Student()
                {
                    LastName="Test",
                    FirstName="Test",
                    Adress = "Test",
                    Phone="Test",
                    IDNP="Test",
                    Email = "Test@google.com",
                }
            };
        }
        public void AddStudent(Student std)
        {
            Students.Add(std);
        }
        public void UpdateStudent(Student student)
        {
            var studentToUpdate = Students.FirstOrDefault(x => x.IDNP == student.IDNP);
            if (studentToUpdate == null)
                throw new Exception("Student was not found");
            var index = Students.IndexOf(studentToUpdate);
            Students[index] = student;
        }
        public void DeleteStudent(string id)
        {
            var student = Students.Where(x => x.IDNP == id).FirstOrDefault()!;
            if (student == null)
                throw new Exception("Student was not found");
            Students.Remove(student);
        }
        public Student GetStudentByID(string id)
        {
            return Students.Where(x => x.IDNP == id).FirstOrDefault()!;
        }
        public List<Student> GetStudents()
        {
            return Students;
        }
    }
}
