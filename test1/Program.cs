using System;
using System.Runtime.CompilerServices;

namespace FirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();
            if (username == "spyynz" && password == "pass")
            {
                Console.WriteLine("Success! You are now logged in as " + username);
                SuccessOutcome();
            }
            else
            {
                Console.WriteLine("Incorrect login. Please try again(Y/N).");
                string confRestart = Console.ReadLine();
                if (confRestart == "Y")
                {
                    Main(args);
                }
                else if (confRestart == "y")
                {
                    Main(args);
                }
                else
                {

                }
            }
        }
        public static void SuccessOutcome()
        {
            Console.WriteLine("SUCCESSFUL LOGIN");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Welcome To...");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("The Cozy Corner with Spyynz :) but please leave now ty");
            Console.ReadKey();
        }
    }
}
