using System;
using System.Threading;

namespace CybersecurityBot
{
    public class Asciidesigner
    {
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║         CYBERSECURITY AWARENESS BOT / South Africa       ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════════╣");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
_________        ___.                 _________                          
\_   ___ \___.__.\_ |__   ___________/   _____/ ____   ____              
/    \  \<   |  | | __ \_/ __ \_  __ \_____  \_/ __ \_/ ___\             
\     \___\___  | | \_\ \  ___/|  | \/        \  ___/\  \___             
 \______  / ____| |___  /\___  >__| /_______  /\___  >\___  >            
        \/\/          \/     \/             \/     \/     \/             
");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void TypeText(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}