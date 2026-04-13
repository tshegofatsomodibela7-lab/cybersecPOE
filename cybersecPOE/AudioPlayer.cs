using System;
using System.IO;
using System.Media;   // Important: Add this using

namespace CybersecurityBot
{
    public class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                // Change the path if you saved the file somewhere else
                string soundPath = "C:\\Users\\Adam\\source\\repos\\cybersecPOE\\cybersecPOE\\voice greeting.wav";

                using (SoundPlayer player = new SoundPlayer(soundPath))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" Playing voice greeting...");
                    Console.ResetColor();

                    player.PlaySync();   // Plays and waits until finished (better for console)
                                         // OR use player.Play(); if you want it to play in background
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Could not play greeting: {ex.Message}");
                Console.WriteLine("Make sure greeting.wav exists in the project folder.");
                Console.ResetColor();

                // Optional: Small delay so user can read the message
                System.Threading.Thread.Sleep(1500);
            }
        }
    }
}
