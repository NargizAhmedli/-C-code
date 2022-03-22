using System;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car1 = new Car()
            {
                Millage = 40;
                CurrentFue1 = 50;
            car1.Drive(40);
            
            }
        }
    }
}
