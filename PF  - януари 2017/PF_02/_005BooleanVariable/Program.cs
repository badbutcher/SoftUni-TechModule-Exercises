namespace _005BooleanVariable
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (Convert.ToBoolean(input) == true)
            {
                Console.WriteLine("Yes");
            }
            else if (Convert.ToBoolean(input) == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}