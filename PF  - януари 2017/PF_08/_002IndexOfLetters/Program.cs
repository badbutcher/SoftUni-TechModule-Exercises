namespace _002IndexOfLetters
{
    using System;
    
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            char[] letters = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                letters[i] = input[i];
            }

            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine(letters[i] + " -> " + ((int)letters[i] - 97));
            }
        }
    }
}