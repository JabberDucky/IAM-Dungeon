using System;

namespace VillageRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Kingdom of WonderLa! Speak thy name, brave adventurer!");
            string name = Console.ReadLine();

            Console.WriteLine("How many winters have you seen?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What path do you follow? (Warrior, Mage, Rogue, wizard, etc)");
            string classType = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("=== Adventurer Profile ===");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Class: {classType}");
        }
    }
}