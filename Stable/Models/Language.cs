using System.ComponentModel.DataAnnotations.Schema;

namespace Stable.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(Trainer))]
        public string TrainerId { get; set; }
        public Trainer Trainer { get; set; }
    }
}
