namespace _010CubeProperties
{
    using System;

    class Program
    {
        static void Main()
        {
            double input = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            switch (parameter)
            {
                case "face":
                    Console.WriteLine("{0:F2}", FindFaceDiagonals(input));
                    break;
                case "space":
                    Console.WriteLine("{0:F2}", FindSpaceDiagonals(input));
                    break;
                case "volume":
                    Console.WriteLine("{0:F2}", FindVolume(input));
                    break;
                case "area":
                    Console.WriteLine("{0:F2}", FindSurfaceArea(input));
                    break;
                default:
                    break;
            }
        }

        private static double FindFaceDiagonals(double side)
        {
            double result = Math.Sqrt(2 * (side * side));
            return result;
        }

        private static double FindSpaceDiagonals(double side)
        {
            double result = Math.Sqrt(3 * (side * side));
            return result;
        }

        private static double FindVolume(double side)
        {
            double result = side * side * side;
            return result;
        }

        private static double FindSurfaceArea(double side)
        {
            double result = 6 * (side * side);
            return result;
        }
    }
}