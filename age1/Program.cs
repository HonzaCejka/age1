using System;

namespace age
{
    class Program
    {

        static void Main(string[] args)
        {

            string yearStr = DateTime.UtcNow.ToString("yyyy");
            int year = int.Parse(yearStr);
            int birth;


            Console.ForegroundColor = ConsoleColor.Red;
            frame(20, 1);



            Console.SetCursorPosition(30, 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Age calculator");
            Console.WriteLine();
            Console.SetCursorPosition(30, 4);
            Console.WriteLine($"current year is {year}");
            Console.SetCursorPosition(30, 5);
            Console.Write("enter year of birth: ");
            Console.SetCursorPosition(52, 5);
            birth = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(30, 7);
            int age = (year - birth);
            Console.WriteLine($"váš věk je {age}");
            Console.WriteLine();
            Console.ReadLine();


            if (age < 15)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                SmallFrame(50, 20);
                Console.SetCursorPosition(50, 23);
                Console.WriteLine("jsi dítě lol");
                Console.ReadLine();
            }


        }

        static void SmallFrame(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine("╔═════════════════════════════════════════════════╗");
            Console.SetCursorPosition(left, top + 1);
            Console.WriteLine("║                                                 ║");
            Console.SetCursorPosition(left, top + 2);
            Console.WriteLine("╚═════════════════════════════════════════════════╝");
        }

        static void frame(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine("╔═════════════════════════════════════════════════╗");
            Console.SetCursorPosition(left, top + 1);
            Console.WriteLine("║                                                 ║");
            Console.SetCursorPosition(left, top + 2);
            Console.WriteLine("╠═════════════════════════════════════════════════╣");
            Console.SetCursorPosition(left, top + 3);
            Console.WriteLine("║                                                 ║");
            Console.SetCursorPosition(left, top + 4);
            Console.WriteLine("║                                                 ║");
            Console.SetCursorPosition(left, top + 5);
            Console.WriteLine("║                                                 ║");
            Console.SetCursorPosition(left, top + 6);
            Console.WriteLine("║                                                 ║");
            Console.SetCursorPosition(left, top + 7);
            Console.WriteLine("║                                                 ║");
            Console.SetCursorPosition(left, top + 8);
            Console.WriteLine("║                                                 ║");
            Console.SetCursorPosition(left, top + 9);
            Console.WriteLine("╚═════════════════════════════════════════════════╝");
            Console.WriteLine();
        }
    }
}