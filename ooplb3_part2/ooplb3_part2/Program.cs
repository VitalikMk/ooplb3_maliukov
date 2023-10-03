namespace ooplb3_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення об'єктів класу Point
            Point A = new Point(1, 2, "A");
            Point B = new Point(3, 4, "B");
            Point C = new Point(5, 6, "C");
            Point D = new Point(7, 8, "D");

            // Створення об'єкта класу Figure
            Figure figure = new Figure(new Point[] { A, B, C, D });

            // Обчислення периметра многокутника
            figure.CalculatePerimeter();
        }
    }
}