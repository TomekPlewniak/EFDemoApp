using System.ComponentModel.DataAnnotations;

namespace EFDataAccessLibrary.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string StreetAddress { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string City { get; set; }
        
        public string State { get; set; }
        
        public string ZipCode { get; set; }
    }
}
