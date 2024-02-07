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

            while (true)
            {
                Console.WriteLine("\nChoose an action: 1. Feed, 2. Play, 3. Rest, 4. Check Status, 5. Quit");
                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        pet.Feed();
                        break;
                    case 2:
                        pet.Play();
                        break;
                    case 3:
                        pet.Rest();
                        break;
                    case 4:
                        pet.CheckStatus();
                        break;
                    case 5:
                        Console.WriteLine("Thanks for playing! Goodbye.");
                        return;
                    default:
                        Console.WriteLine("Invalid action. Please try again.");
                        break;
                }
            }
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

        public void Play()
        {
            happiness++;
            hunger++;
            Console.WriteLine($"{petName} played. Happiness: {happiness}, Hunger: {hunger}");
        }

        public void Rest()
        {
            happiness--;
            health++;
            Console.WriteLine($"{petName} rested. Happiness: {happiness}, Health: {health}");
        }

        public void CheckStatus()
        {
            Console.WriteLine($"{petName}'s stats: Hunger: {hunger}, Happiness: {happiness}, Health: {health}");

            if (hunger <= 2 || happiness <= 2 || health <= 2)
            {
                Console.WriteLine("Warning: Your pet's stats are critically low. Please take action.");
            }
            else if (hunger >= 10 || happiness >= 10 || health >= 10)
            {
                Console.WriteLine("Warning: Your pet's stats are critically high. Please take action.");
            }
            else
            {
                Console.WriteLine("Your pet's stats are Good!!!. No action required.");
            }
        }
    }
}
