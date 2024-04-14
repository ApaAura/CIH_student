namespace laborator_1.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public string? Instructor { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set;}
    }
}
