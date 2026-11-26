namespace Checkers.Models
{
    public class Player
    {
        public string Name { get; set; }
        public PlayerColor Color { get; }
        public int Score { get; set; }
        public bool Resigned { get; set; }

        public Player(PlayerColor color, string name)
        {
            Color = color;
            Name = name;
        }
    }
}
