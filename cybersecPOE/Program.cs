using System;

namespace CybersecurityBot
{
    class Program
    {
        static void Main()
        {
            Asciidesigner.ShowLogo();
            AudioPlayer.PlayGreeting();     // We'll create this next

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter your name: ");
            Console.ResetColor();

            string name = Console.ReadLine()?.Trim() ?? "";

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Name cannot be empty. Please try again: ");
                Console.ResetColor();
                name = Console.ReadLine()?.Trim() ?? "";
            }

            Chatbot bot = new Chatbot(name);
            bot.StartChat();
        }
    }
}
