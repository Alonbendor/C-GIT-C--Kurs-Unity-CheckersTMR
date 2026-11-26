using System;

namespace Checkers.Models
{
    public readonly struct Position
    {
        public int Row { get; }
        public int Col { get; }

        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public static Position operator +(Position a, Position b) => new Position(a.Row + b.Row, a.Col + b.Col);

        public static bool operator ==(Position a, Position b) => a.Row == b.Row && a.Col == b.Col;

        public static bool operator !=(Position a, Position b) => !(a == b);

        public override bool Equals(object obj) => obj is Position other && this == other;

        public override int GetHashCode() => HashCode.Combine(Row, Col);

        public override string ToString() => $"({Row}, {Col})";
    }
}
