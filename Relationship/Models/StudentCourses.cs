using System.ComponentModel.DataAnnotations;

namespace Relationship.Models
{
    public class StudentCourses
    {
        [Key]
        public int StudentCourseId { get; set; }
        public int StudentId { get; set; }
        public Student Students { get; set; }

        public int CourseId { get; set; }
        public Course Courses { get; set; }
    }
}
