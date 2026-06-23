namespace VillageRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string classType;

            Console.WriteLine("Welcome to the Kingdom of WonderLa! I see you are here to register with the Knights of Identity. Speak thy name, brave adventurer!");
            name = Console.ReadLine();

            Console.WriteLine("How many winters have you seen?");
            int.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("What path do you follow? (Warrior, Mage, Rogue, wizard, etc)");
            classType = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("=== Adventurer Profile ===");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Class: {classType}");

            Console.WriteLine();

            CheckWinters(age, name);

            Console.WriteLine();


        }

        static void CheckWinters(int age, string name)
        {
            if (age >= 21)
            {
                Console.WriteLine($"Welcome, {name}! you are eligible to become a member of the Knights of Identity. May your adventures be legendary!");
            }
            else
            {
                Console.WriteLine($"Alas, {name}, you are not yet of age to join the Knights of Identity. You may return when you have seen more winters!");
            }
        }
    }
}

