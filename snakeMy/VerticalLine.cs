namespace Snake
{
    internal class VerticalLine
    {
        List<Point> pointsLine;
        public VerticalLine(int x, int yLow, int yTop, char sym)
        {
            pointsLine = new List<Point>();
            for (int y = yLow; y <= yTop; y++)
            {
                Point pLine = new Point(x, y, sym);
                pointsLine.Add(pLine);
            }
        }
        public void DrawLine()
        {
            foreach (Point item in pointsLine)
            {
                item.Draw();
            }
        }
    }
}