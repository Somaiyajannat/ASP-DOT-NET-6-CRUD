namespace Relationship.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<AddressDetails> AddressDetails { get; set;}

    }

}
