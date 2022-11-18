using System.ComponentModel.DataAnnotations;

namespace Relationship.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseCredit { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
