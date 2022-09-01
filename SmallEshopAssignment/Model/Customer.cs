using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SmallEshopAssignment.Model
{
    public class Customer
    {
        [JsonIgnore]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PostalCode    { get; set; }
    }
}
