using System;

namespace favorite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my first C# Program");
            Console.Write("What is your favorite number? ");
            int favenumb = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your favorite animal? ");
            string faveanim = Console.ReadLine();
            Console.WriteLine("Your favorite number is " + favenumb);
            string an = faveanim.Substring(0, 1); // Get the first letter in "faveanim"
            if (an == "a" || an == "e" || an == "i" || an == "o" || an == "u") // If it is a vowel
            {
                Console.WriteLine("Your favorite animal is an " + faveanim); // Use "an"
            }
            else // Or Else, 
            {
                Console.WriteLine("Your favorite animal is a " + faveanim); // Use "a"
            }
        }
    }
}