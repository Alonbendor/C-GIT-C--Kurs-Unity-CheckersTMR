namespace Checkers.Models
{
    public class BoardModel
    {
        public const int Size = 8;
        private const int RowsPerSide = 3;

        private readonly Piece[,] _grid = new Piece[Size, Size];

        public PlayerColor CurrentTurn { get; set; } = PlayerColor.White;

        public BoardModel()
        {
            PlaceStartingPieces();
        }

        public bool IsInside(Position position)
        {
            return position.Row >= 0 && position.Row < Size
                && position.Col >= 0 && position.Col < Size;
        }

        // Returns the piece on the square, or null if the square is empty.
        public Piece GetPiece(Position position)
        {
            return _grid[position.Row, position.Col];
        }

        // Pass null to empty the square.
        public void SetPiece(Position position, Piece piece)
        {
            _grid[position.Row, position.Col] = piece;
        }

        private void PlaceStartingPieces()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    bool isDarkSquare = (row + col) % 2 == 1;
                    if (!isDarkSquare)
                    {
                        continue;
                    }

                    if (row < RowsPerSide)
                    {
                        _grid[row, col] = new Piece(PlayerColor.Black);
                    }
                    else if (row >= Size - RowsPerSide)
                    {
                        _grid[row, col] = new Piece(PlayerColor.White);
                    }
                }
            }
        }
    }
}
