using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class Student
    {
        [Key]
        public int SudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string IDNP { get; set; }
        public string city { get; set; }
       // public virtual ICollection<Marks> Marks { get; set; }
    }
}
