namespace Consnake.Core.Models
{
    public class Snake
    {
        public List<(int X, int Y)> Body { get; private set; }
        public (int X, int Y) Head => Body.First();
        public (int X, int Y) Tail => Body.Last();
        public (int X, int Y) LastTail { get; private set; }
        public Snake(int startX, int startY)
        {
            Body = new List<(int X, int Y)> { (startX, startY) };
            LastTail = Tail;
        }

        public void Grow()
        {
            Body.Add(LastTail);
        }

        public void Move(int deltaX, int deltaY)
        {
            LastTail = Body.Last();
            for (int i = Body.Count - 1; i > 0; i--)
            {
                Body[i] = Body[i - 1];
            }
            Body[0] = (Body[0].X + deltaX, Body[0].Y + deltaY);
        }
    }
}
