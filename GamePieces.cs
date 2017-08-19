namespace Game
{
    public class GamePiece
    {
        int positionX { get; set; }
        int positionY { get; set; }
        bool frozen { get; set; }
        private string name { get; set; }

        public GamePiece()
        {
            positionX = 0;
            positionY = 0;
            frozen = false;
            System.Console.WriteLine($"{this.positionX}");

            public void move(int x, int y)  //why not?
            {
                System.Console.WriteLine("moving to the");
                if (this.frozen == false)
                {
                    this.positionY = y;
                    this.positionX = x;
                }
            }
            public void freeze()
            {
                //if the game piece is not frozen
                // then call the freeze sets to the frozen variable true

                if (this.frozen == false)
                {
                    this.frozen = true;
                }
                System.Console.WriteLine(this.frozen);
            }
            public void unfreeze()
            {
                if (this.frozen == true)
                {
                    this.frozen = false;
                }
                System.Console.WriteLine(this.frozen);
            }

            public void move(int x, int y)
            {
                System.Console.WriteLine("moving to the");
                if (this.frozen == false)
                {
                    this.positionY = y;
                    this.positionX = x;
                }

            }
        }
    }
}
