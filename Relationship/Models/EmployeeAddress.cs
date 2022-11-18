using System.ComponentModel.DataAnnotations;

namespace Relationship.Models
{
    public class EmployeeAddress
    {
        [Key]
        public int AddressId { get; set;}
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set;}
        public Employee Employee { get; set;}
        public Employee Employees;
    }
}
