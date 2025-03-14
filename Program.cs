using System;

namespace Method_McVey_Cason
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks for a whole number
            Console.WriteLine("Please enter a whole number!");
            // Read the number you said
            int x = Convert.ToInt32(Console.ReadLine());
            // Asks for another whole number
            Console.WriteLine("Please enter another whole number!");
            // Read the number you said
            int y = Convert.ToInt32(Console.ReadLine());

            // Multiply both of them
            Console.WriteLine(Multiply(x,y));

            // Asks for your name
            Console.WriteLine("What is your name?");
            // Reads the name you type down
            string name = Console.ReadLine();

            // Calls this method
            WelcomeUser(name);

            // Calls this method
            Goodbye();
        }

        // Multiply two integer together that you said
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }


        // Prints a welcome message
        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username}! It is nice to meet you!");
        }

        // Prints a goodbye message
        static void Goodbye()
        {
            Console.WriteLine("Have a nice day!");
        }

    }
}