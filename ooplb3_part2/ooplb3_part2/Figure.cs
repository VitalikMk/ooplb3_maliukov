

namespace ooplb3_part2
{
    public class Figure
    {
        private Point[] points;

        public Figure(Point[] points)
        {
            this.points = points;
        }

        public double GetSideLength(Point A, Point B)
        {
            return Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }

        public void CalculatePerimeter()
        {
            // Обчислення периметра многокутника
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += GetSideLength(points[i], points[i + 1]);
            }
            perimeter += GetSideLength(points[points.Length - 1], points[0]);

            // Виведення периметра на консоль
            Console.WriteLine("Периметр многокутника: {0}", perimeter);
        }
    }
}
