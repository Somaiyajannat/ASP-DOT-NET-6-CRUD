using System.ComponentModel.DataAnnotations;

namespace Relationship.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        [StringLength(50)]
        public string? GradeName { get; set; }
        [StringLength(20)]
        public string? Section { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
