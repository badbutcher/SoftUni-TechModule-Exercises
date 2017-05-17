namespace _006StringsAndObjects
{
    using System;

    class Program
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            var combinedStings = hello + " " + world;
            var result = combinedStings.ToString();
            Console.WriteLine(result);
        }
    }
}