using System;

namespace VillageRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string classType;

            Console.WriteLine("Welcome to the Kingdom of WonderLa! Speak thy name, brave adventurer!");
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

         
        }
    }
}