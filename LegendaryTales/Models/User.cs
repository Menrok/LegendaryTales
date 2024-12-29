namespace LegendaryTales.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public required List<Player> Players { get; set; }
    }
}
