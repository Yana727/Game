using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePiece queen = new GamePiece();
            queen.move(4, 5);
            GamePiece pawn = new GamePiece();
            pawn.freeze();
        }
    }
}
