namespace _008CenterPoint
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

            ClosestToTheCenter(x1, y1, x2, y2);
        }

        private static void ClosestToTheCenter(double x1, double y1, double x2, double y2)
        {
            double xy1 = Math.Abs(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double xy2 = Math.Abs(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (xy1 <= xy2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}