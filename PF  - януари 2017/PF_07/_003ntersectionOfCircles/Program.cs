namespace _003ntersectionOfCircles
{
    using System;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            double[] A = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] B = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double AX = A[0];
            double AY = A[1];
            double ARadius = A[2];
            double BX = B[0];
            double BY = B[1];
            double BRadius = B[2];
            Point centerOne = new Point() { X = AX, Y = AY };
            Point centerTwo = new Point() { X = BX, Y = BY };
            Circle circleOne = new Circle() { Center = centerOne, Radius = ARadius };
            Circle circleTwo = new Circle() { Center = centerTwo, Radius = BRadius };
            double distance = CalcDistance(centerOne, centerTwo);
            if (distance <= circleOne.Radius + circleTwo.Radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static double CalcDistance(Point a, Point b)
        {
            double distance = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
            return distance;
        }
    }

    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}