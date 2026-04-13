
using System;

namespace CybersecurityBot
{
    public class Greeting
    {
        // Automatic Properties - required by rubric
        public string UserName { get; private set; }
        public string WelcomeMessage { get; private set; }

        public Greeting(string name)
        {
            UserName = name;
            WelcomeMessage = $"Welcome, {UserName}! I'm your Cybersecurity Awareness Assistant.";
        }

        public void DisplayWelcome()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"║    {WelcomeMessage,-53}║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╠══════════════════════════════════════════════════════════╣");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║  I can help you with:                                    ║");
            Console.WriteLine("║       Password Safety                                    ║");
            Console.WriteLine("║       Phishing Awareness                                 ║");
            Console.WriteLine("║       Safe Browsing                                      ║");
            Console.WriteLine("║       Malware Protection                                 ║");
            Console.WriteLine("║       Social Engineering & Scams                         ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();

            Asciidesigner.TypeText("Let's get started! Type 'help' to see topics or just ask away.",
                ConsoleColor.Green);
            Console.WriteLine();
        }
    }
}