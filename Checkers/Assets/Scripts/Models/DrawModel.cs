namespace Checkers.Models
{
    public class DrawModel
    {
        public int KingOnlyMoves { get; set; }
        public int EndingMoves { get; set; }

        public void Reset()
        {
            KingOnlyMoves = 0;
            EndingMoves = 0;
        }
    }
}
