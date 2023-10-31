using System;

namespace Programm
{
    class PianoApp
    {
        public static Dictionary<int, int[]> ValueOctyava = new Dictionary<int, int[]>()
        {
            {1, new int[] { 2093, 2217, 2349, 2489, 2637, 2837 }},
            {2, new int[] { 4186, 4435, 4699, 4978, 5274, 6337 }}
        };

        static int Ocktava = 1;
        static void Main()
        {
            Console.WriteLine("Переключение между Октавами F1-F2");
            Console.WriteLine("Клавишы управления: A | S | D | F | G | H");
            ConsoleKey key = Console.ReadKey().Key;

            while (key != ConsoleKey.Escape)
            {
                if (key == ConsoleKey.F1) Console.WriteLine("Октава 7"); Ocktava = 1; AudioSound(key);
                if (key == ConsoleKey.F2) Console.WriteLine("Октава 8"); Ocktava = 2; AudioSound(key);

                key = Console.ReadKey().Key;
                AudioSound(key);
                Console.Clear();
            }
        }

        public static void AudioSound(ConsoleKey bind)
        {
            switch (bind)
            {
                case ConsoleKey.A:        
                    Console.Beep(ValueOctyava[Ocktava][0], 300);
                    break;
                case ConsoleKey.S:
                    Console.Beep(ValueOctyava[Ocktava][1], 300);
                    break;
                case ConsoleKey.D:
                    Console.Beep(ValueOctyava[Ocktava][2], 300);
                    break;
                case ConsoleKey.F:
                    Console.Beep(ValueOctyava[Ocktava][3], 300);
                    break;
                case ConsoleKey.G:
                    Console.Beep(ValueOctyava[Ocktava][4], 300);
                    break;
                case ConsoleKey.H:
                    Console.Beep(ValueOctyava[Ocktava][5], 300);
                    break;
            }
        }
    }
    
}

