using System.Collections.Generic;

namespace Checkers.Models
{
    public class Move
    {
        public Position From { get; }
        public IReadOnlyList<Position> Path { get; }
        public IReadOnlyList<Position> Captured { get; }
        public Position To => Path[Path.Count - 1];
        public bool IsCapture => Captured.Count > 0;

        public Move(Position from, IReadOnlyList<Position> path, IReadOnlyList<Position> captured)
        {
            From = from;
            Path = path;
            Captured = captured;
        }
    }
}
