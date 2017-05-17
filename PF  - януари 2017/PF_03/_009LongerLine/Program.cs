namespace _009LongerLine
{
    using System;

    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            ClosestToTheCenter(x1, y1, x2, y2, x3, y3, x4, y4);

            if (LongestLine(x1, y1, x2, y2) == LongestLine(x3, y3, x4, y4))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }

        private static double LongestLine(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        private static void ClosestToTheCenter(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double xy1 = Math.Abs(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double xy2 = Math.Abs(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            double xy3 = Math.Abs(Math.Pow(x3, 2) + Math.Pow(y3, 2));
            double xy4 = Math.Abs(Math.Pow(x4, 2) + Math.Pow(y4, 2));

            if ((xy1 + xy2) > (xy3 + xy4))
            {
                if (xy1 > xy2)
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }

            if ((xy3 + xy4) > (xy1 + xy2))
            {
                if (xy3 > xy4)
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
            }
        }
    }
}