using System;
using System.Threading;

namespace ZodiacPersonality
{
    class Program
    {
        static void writing(string message, int delay = 55)
        {
            foreach (char ch in message)
            {
                Console.Write(ch);
                Thread.Sleep(delay);
            }

        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("\n\n\t\t\t\t\t\t\t");
            writing("Welcome!");
            Thread.Sleep(800);
            Console.Write(" \n\n\t\t\t\t");
            writing(" Let's find out your Zodiac sign and personality!!");
            Thread.Sleep(600);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\tpress 'ESC' to continue.");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape) { }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            writing("\n Please enter your birth date in DDMM format (e.g., 0502 for 5 February):");

            string input = Console.ReadLine().Trim();

            if (input == null || input.Length != 4 || !int.TryParse(input, out int birthDate))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                writing("Invalid input! Please run the program again and enter in DDMM format.");
                Console.ResetColor();
                return;
            }
            Console.Clear();
            int day = int.Parse(input.Substring(0, 2));
            int month = int.Parse(input.Substring(2, 2));

            string zodiac = GetZodiac(day, month);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n\n");
            writing("  So now....");
            Thread.Sleep(3000);
            writing($"\n\n Your Zodiac sign is: {zodiac}\n\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            ShowPersonality(zodiac);

            Console.ResetColor();
        }

        static string GetZodiac(int day, int month)
        {
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                return "Aries";
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                return "Taurus";
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
                return "Gemini";
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
                return "Cancer";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return "Leo";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return "Virgo";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                return "Libra";
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                return "Scorpio";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return "Sagittarius";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                return "Capricorn";
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                return "Aquarius";
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
                return "Pisces";
            else
                return "Unknown";
        }

        static void ShowPersonality(string zodiac)
        {
            switch (zodiac.ToLower())
            {
                case "aries":
                    writing(" Aries: Bold, ambitious, and passionate. You dive into challenges headfirst.\n You are a natural leader who inspires others with your courage and enthusiasm.");
                    break;
                case "taurus":
                    writing(" Taurus: Reliable, patient, and sensual. You love comfort and stability.\n Your determination helps you achieve long-term goals and you value loyalty in relationships.");
                    break;
                case "gemini":
                    writing(" Gemini: Energetic, witty, and adaptable. Your mind is always racing, and you excel at communication.\n You're curious and love to learn new things.");
                    break;
                case "cancer":
                    writing(" Cancer: Emotional, nurturing, and loyal. You protect the ones you love fiercely. \nYour intuition and empathy make you a caring friend and family member.");
                    break;
                case "leo":
                    writing(" Leo: Confident, creative, and charismatic. You light up every room with your presence. \nYou're generous and enjoy being admired and appreciated.");
                    break;
                case "virgo":
                    writing(" Virgo: Analytical, practical, and caring. You seek perfection in all things and work hard to improve yourself and those around you. \nYour attention to detail is unmatched.");
                    break;
                case "libra":
                    writing(" Libra: Charming, fair-minded, and social. You love balance and beauty, often seeking harmony in your environment.\n You're diplomatic and great at resolving conflicts.");
                    break;
                case "scorpio":
                    writing(" Scorpio: Intense, mysterious, and powerful. You feel deeply and love hard.\n Your passion and determination help you overcome any obstacle.");
                    break;
                case "sagittarius":
                    writing(" Sagittarius: Free-spirited, curious, and optimistic. You crave adventure and love exploring new ideas and places.\n Your enthusiasm is contagious.");
                    break;
                case "capricorn":
                    writing(" Capricorn: Ambitious, disciplined, and wise. You reach goals others fear to try for. Your strong sense of responsibility makes you dependable and respected.");
                    break;
                case "aquarius":
                    writing(" Aquarius: Innovative, independent, and visionary. You think outside the box and care deeply about\n making the world a better place. Your originality shines bright.");
                    break;
                case "pisces":
                    writing(" Pisces: Intuitive, artistic, and gentle. You live in a world of dreams and emotions. \nYour empathy and creativity make you a wonderful friend and companion.");
                    break;
                default:
                    writing("We couldn't identify your zodiac sign clearly, but remember you are unique and special in your own way!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
