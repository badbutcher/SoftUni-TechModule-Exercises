﻿namespace _018DifferentIntegersSize
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());

            if (input > long.MaxValue || input < long.MinValue)
            {
                Console.WriteLine(input + " can't fit in any type");
            }
            else
            {
                Console.WriteLine(input + " can fit in:");
                if (input >= sbyte.MinValue && input <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }

                if (input >= byte.MinValue && input <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }

                if (input >= short.MinValue && input <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }

                if (input >= ushort.MinValue && input <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }

                if (input >= int.MinValue && input <= int.MaxValue)
                {
                    Console.WriteLine("* int ");
                }

                if (input >= uint.MinValue && input <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }

                if (input >= long.MinValue && input <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }        
        }
    }
}