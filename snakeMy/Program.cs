namespace Snake
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            HorizontalLine hLine1 = new HorizontalLine(5, 20, 8, '+');
            VerticalLine vLine = new VerticalLine(20, 8, 20, '+');
            Point p1 = new Point(1, 5, '*');
            p1.Draw();
            hLine1.DrawLine();
            vLine.DrawLine();



        }

    }
}

