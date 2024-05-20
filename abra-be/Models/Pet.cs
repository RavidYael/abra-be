using System.ComponentModel.DataAnnotations;

namespace abra_be.Models
{
    public class Pet
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(100)]
        public DateTime CreatedAt { get; set; }

        [Required]
        public PetType Type { get; set; }
        
        public enum PetType
        {
            Dog,
            Cat,
            Horse,
            Other
        }
        
        [Required]
        public string Color { get; set; }
        
        [Required]
        public int Age { get; set; }
    }
}
