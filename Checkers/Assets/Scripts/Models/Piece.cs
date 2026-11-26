namespace Checkers.Models
{
    public class Piece
    {
        public PlayerColor Color { get; }
        public PieceType Type { get; private set; }
        public bool IsKing => Type == PieceType.King;

        public Piece(PlayerColor color, PieceType type = PieceType.Man)
        {
            Color = color;
            Type = type;
        }

        public void Promote()
        {
            Type = PieceType.King;
        }
    }
}
