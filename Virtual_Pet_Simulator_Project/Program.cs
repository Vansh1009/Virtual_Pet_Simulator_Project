using System;

namespace VirtualPetSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Virtual Pet Simulator!");
            Console.WriteLine("Choose a pet type: 1. Cat, 2. Dog, 3. Rabbit");
            int petType = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your pet's name:");
            string petName = Console.ReadLine();

        }
    }
}