using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace abra_be.Models
{
    public class Pet
    {
        
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required]
        [StringLength(100)]
        [BsonElement("name")]
        public string Name { get; set; }
        
        [Required]
        [StringLength(100)]
        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [BsonElement("type")]
        public PetType Type { get; set; }
        
        public enum PetType
        {
            Dog,
            Cat,
            Horse,
            Other
        }
        
        [Required]
        [BsonElement("color")]
        public string Color { get; set; }
        
        [Required]
        [BsonElement("age")]
        public int Age { get; set; }
    }
}
