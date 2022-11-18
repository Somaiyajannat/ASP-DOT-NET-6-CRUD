namespace Relationship.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public Classroom Classroom { get; set; }
        public Grade Grade { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
