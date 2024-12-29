using System.ComponentModel.DataAnnotations;

namespace LegendaryTales.Models
{
    public class Item
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Type { get; set; }
        public int? Defense { get; set; } 
        public int? Attack { get; set; }

        public int PriceBuy { get; set; }
        public int PriceSell { get; set; }

        public bool IsEquipped { get; set; } = false;

        public ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
