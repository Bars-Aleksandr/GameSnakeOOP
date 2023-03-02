namespace Snake
{
    class HorizontalLine
    {
        List<Point> pointsLine;
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pointsLine = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
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