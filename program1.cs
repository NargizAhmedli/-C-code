using System;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add book.");
                Console.WriteLine("2. Get book by id");
                Console.WriteLine("3. Remove book");
                Console.WriteLine("0. Quit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":

                    default:
                        break;
                }

            } while (check);
        }
    }
}
