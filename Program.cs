using System;

namespace number_guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            // guess the random number generated between 0 & 100

            Random r = new Random();
            int magicNumber = r.Next(1, 100);
            bool win = false;

            Console.WriteLine("* Welcome to the Guessing Game! *");
            Console.WriteLine("=================================");

            do
            {
                
                Console.WriteLine("Guess the number between 1 & 100:");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > magicNumber) {
                    Console.WriteLine("To high, try again...");
                } else if (i < magicNumber) {
                    Console.WriteLine("To low, try again...");
                } else if (i == magicNumber) {
                    Console.WriteLine("=================================");
                    Console.WriteLine("************ YOU WIN ************");
                    Console.WriteLine("=================================");
                    win = true;
                }

                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("Thanks for playing");
            Console.Write("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}
