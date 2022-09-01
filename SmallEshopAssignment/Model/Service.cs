using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SmallEshopAssignment.Model
{
    public class Service
    {
        [JsonIgnore]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description  { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
