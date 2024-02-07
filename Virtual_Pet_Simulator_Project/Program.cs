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

            Pet pet = new Pet(petType, petName);

      
        }
    }
    class Pet
    {
        private int petType;
        private string petName;
        private int hunger;
        private int happiness;
        private int health;

        public Pet(int petType, string petName)
        {
            this.petType = petType;
            this.petName = petName;
            this.hunger = 5;
            this.happiness = 5;
            this.health = 5;
        }

        public void Feed()
        {
            hunger--;
            health++;
            Console.WriteLine($"{petName} was fed. Hunger: {hunger}, Health: {health}");
        }
    }
}
