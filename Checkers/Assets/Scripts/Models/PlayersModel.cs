namespace Checkers.Models
{
    public class PlayersModel
    {
        public Player White { get; }
        public Player Black { get; }

        public PlayersModel(string whiteName = "White", string blackName = "Black")
        {
            White = new Player(PlayerColor.White, whiteName);
            Black = new Player(PlayerColor.Black, blackName);
        }

        public Player GetByColor(PlayerColor color) => color == PlayerColor.White ? White : Black;
    }
}
