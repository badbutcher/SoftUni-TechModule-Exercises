namespace _007ExchangeVariableValues
{
    using System;

    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c = 0;

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }
}