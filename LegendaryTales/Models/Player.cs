using System.ComponentModel.DataAnnotations;

namespace LegendaryTales.Models
{
    public class Player
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Imię postaci jest wymagane.")]
        public required string Name { get; set; }
        public int Level { get; set; } = 1;
        public int Experience { get; set; } = 0;
        public int PointsToSpend { get; set; } = 0;
        public int Health { get; set; } = 100;
        public int MaxHealth { get; set; } = 100;
        public int Attack { get; set; } = 0;
        public int Defense { get; set; } = 0;
        public int Gold { get; set; } = 0;

        public ICollection<Item> Items { get; set; } = new List<Item>();
      
        public int UserId { get; set; }
        public required User User { get; set; }
    }
}
