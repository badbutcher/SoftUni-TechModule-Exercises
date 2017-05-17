namespace _012RectangleProperties
{
    using System;

    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = (a + b) * 2;
            double perimeter = a * b;
            double diagonal = Math.Sqrt(a * a + b * b);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
            Console.WriteLine(diagonal);
        }
    }
}