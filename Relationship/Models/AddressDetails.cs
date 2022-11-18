using System.ComponentModel.DataAnnotations;

namespace Relationship.Models
{
    public class AddressDetails
    {
        [Key]
        public int AddressId { get; set; }
        public string District { get; set; }
        public string Thana { get; set; }
        
    }
}
