namespace _013VowelOrDigit
{
    using System;

    class Program
    {
        static void Main()
        {
            char a = char.Parse(Console.ReadLine());

            if (char.IsDigit(a))
            {
                Console.WriteLine("digit");
            }
            else if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u' || a == 'y')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}