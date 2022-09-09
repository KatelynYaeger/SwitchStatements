using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi friend! What's your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"Lovely to meet you {userName}! Let's get down to business. What is your favorite school subject?");
            var response = Console.ReadLine();
            switch(response)

            {
                case ("Math"):
                Console.WriteLine("Really? I hate math.");
                break;

                case ("History"):
                    Console.WriteLine("Cool! What happened today in 1914?");
                    break;

                case ("English"):
                    Console.WriteLine("That's neat. I never learned to read.");
                    break;

                case ("Science"):
                    Console.WriteLine("Eww, why?");
                    break;

                case ("Recess"):
                    Console.WriteLine("I knew you and I would be friends");
                    break;

                default:
                    Console.WriteLine("I'm not familiar with that one.");
                    break;
             










            }
        }
    }
}

