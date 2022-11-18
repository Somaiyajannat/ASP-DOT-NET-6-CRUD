namespace Relationship.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
