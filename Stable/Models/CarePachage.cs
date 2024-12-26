using System.ComponentModel.DataAnnotations.Schema;

namespace Stable.Models
{
    public class CarePachage:BaseEntity
    {
      
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        [ForeignKey(nameof(Horse))]
        public string? HorseId { get; set; }
        public Horse Horse { get; set; }
     
        
    }
}
