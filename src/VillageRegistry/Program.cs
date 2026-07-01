namespace VillageRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string classType;
            bool hasRoyalRecommendation = true;

            Console.WriteLine(@"
██╗ █████╗ ███╗   ███╗
██║██╔══██╗████╗ ████║
██║███████║██╔████╔██║
██║██╔══██║██║╚██╔╝██║
██║██║  ██║██║ ╚═╝ ██║
╚═╝╚═╝  ╚═╝╚═╝     ╚═╝

██████╗ ██╗   ██╗███╗   ██╗ ██████╗ ███████╗ ██████╗ ███╗   ██╗
██╔══██╗██║   ██║████╗  ██║██╔════╝ ██╔════╝██╔═══██╗████╗  ██║
██║  ██║██║   ██║██╔██╗ ██║██║  ███╗█████╗  ██║   ██║██╔██╗ ██║
██║  ██║██║   ██║██║╚██╗██║██║   ██║██╔══╝  ██║   ██║██║╚██╗██║
██████╔╝╚██████╔╝██║ ╚████║╚██████╔╝███████╗╚██████╔╝██║ ╚████║
╚═════╝  ╚═════╝ ╚═╝  ╚═══╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚═╝  ╚═══╝
");
            Console.WriteLine(@"╔══════════════════════════════════════════════╗                                         
║                                              ║
║       A journey through Identity & Access    ║
║             Adventure Simulator              ║
║                                              ║
║        The Begining - Village Registry       ║
║                                              ║
╚══════════════════════════════════════════════╝");
            Console.WriteLine("Press ENTER to begin...");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("You have finally made it to the Kingdom of Authoria!");
            Console.WriteLine("Standing before you are massive gates of anicent dark oak wood, bound with thick black iron and etched with intricate carvings of keys, shields, and endless swirling patterns.");
            Console.WriteLine("As you lift your gaze, you notice an inscription carved into the stone above the gates:");
            Console.WriteLine("\"Only those who prove their true identity may enter.\"");
            Console.WriteLine("The soft clink of steel echoes across the stone as a sentry clad in brilliant silver armor steps forward, every polished plate engraved with the same swirling patterns as the gates. Their square-shaped helm conceals their face entirely, interrupted only by a dark T-shaped visor.");
            Console.WriteLine("They begin to unfurl a weathered parchment. Then, a deep voice reverbrates from within the helm, \"Welcome, traveler. If you wish to pass through the gates of Authoria, you must prove who you are\"");
            Console.WriteLine("You watch as they withdraw a delicate owl feather quill from the leather pouch at their hip, \"Let us begin, what is thy name?\"");
            name = Console.ReadLine();
            Console.Clear();

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

            CheckWinters(age, name, hasRoyalRecommendation);

            Console.WriteLine();

            
        }

        static void CheckWinters(int age, string name, bool hasRoyalRecommendation)
        {
            if (age >= 21 && hasRoyalRecommendation)
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

