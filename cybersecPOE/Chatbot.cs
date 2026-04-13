using System;

namespace CybersecurityBot
{
    public class Chatbot
    {
        public string UserName { get; private set; }

        public Chatbot(string name)
        {
            UserName = name;
        }

        public void StartChat()
        {
            Asciidesigner.TypeText($"\nHello {UserName}! Ask me anything about cybersecurity.");
            Console.WriteLine("Type 'exit' or 'quit' to end the chat.\n");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("> ");
                Console.ResetColor();

                string? input = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I didn't understand that. Please type something.");
                    Console.ResetColor();
                    continue;
                }

                string inputLower = input.ToLower();

                if (inputLower == "exit" || inputLower == "quit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thank you for chatting! Stay safe online! ");
                    Console.ResetColor();
                    break;
                }

                Respond(inputLower);
            }
        }

        private void Respond(string input)
        {
            if (input.Contains("how are you"))
            {
                Console.WriteLine("I'm functioning at 100%! Ready to help you stay safe online.");
            }
            else if (input.Contains("purpose") || input.Contains("who are you"))
            {
                Console.WriteLine("My purpose is to teach South African citizens about cybersecurity awareness.");
            }
            else if (input.Contains("hello") || input.Contains("hi"))
            {
                Console.WriteLine($"Hi {UserName}! How can I help you stay safe online today?");
            }
            else if (input.Contains("what can i ask") || input.Contains("help") || input.Contains("topics"))
            {
                Console.WriteLine("You can ask me about: passwords, phishing, safe browsing, malware, and scams!");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Always use strong, unique passwords. Mix uppercase, lowercase, numbers, and symbols. Consider a password manager!");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Never click suspicious links. Check the sender's email address carefully. When in doubt, don't click!");
            }
            else if (input.Contains("safe browsing") || input.Contains("link"))
            {
                Console.WriteLine("Always hover over links before clicking. Look for 'https://' and the padlock icon.");
            }
            else if (input.Contains("malware") || input.Contains("virus"))
            {
                Console.WriteLine("Install reputable antivirus software and keep it updated. Never download files from unknown sources.");
            }
            else if (input.Contains("social engineering") || input.Contains("scam"))
            {
                Console.WriteLine("Be cautious of unsolicited calls or emails asking for personal info. Always verify identities first.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, I didn't quite understand that. Could you rephrase your question?");
                Console.ResetColor();
            }
        }
    }
}