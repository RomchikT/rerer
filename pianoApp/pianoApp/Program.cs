using System;

namespace Programm
{
    class PianoApp
    {
        static int[] PervaOcktava = new int[] { 2093, 2217, 2349, 2489, 2637 };
        static int[] VtoraOcktava = new int[] { 4186, 4435, 4699, 4978, 5274 };

        static int Ocktava = 1;
        static void Main()
        {
            Console.WriteLine("Переключение между Октавами F1-F2");
            Console.WriteLine("Клавишы управления: A | S | D | F | G | H");
            ConsoleKey key = Console.ReadKey().Key;

            while(key != ConsoleKey.Escape)
            {
                if (key == ConsoleKey.F1)
                {
                    Console.WriteLine("Октава 7");
                    Ocktava = 1;
                    AudioSound(key);
                }
                if (key == ConsoleKey.F2)
                {
                    Console.WriteLine("Октава 8");
                    Ocktava = 2;
                    AudioSound(key);
                }

                key = Console.ReadKey().Key;
                AudioSound(key);
                Console.Clear();
            }
        }

        public static void AudioSound(ConsoleKey bind)
        {
                switch(bind)
                {
                    case ConsoleKey.A:
                        if(Ocktava == 1)
                        {
                            Console.Beep(PervaOcktava[0], 300);
                        }
                        if (Ocktava == 2)
                        {
                            Console.Beep(VtoraOcktava[0], 300);
                        }
                        break;
                    case ConsoleKey.S:
                        if (Ocktava == 1)
                        {
                            Console.Beep(PervaOcktava[1], 300);
                        }
                        if (Ocktava == 2)
                        {
                            Console.Beep(VtoraOcktava[1], 300);
                        }
                        break;
                    case ConsoleKey.D:
                        if (Ocktava == 1)
                        {
                            Console.Beep(PervaOcktava[2], 300);
                        }
                        if (Ocktava == 2)
                        {
                            Console.Beep(VtoraOcktava[2], 300);
                        }
                        break;
                    case ConsoleKey.F:
                        if (Ocktava == 1)
                        {
                            Console.Beep(PervaOcktava[3], 300);
                        }
                        if (Ocktava == 2)
                        {
                            Console.Beep(VtoraOcktava[3], 300);
                        }
                        break;
                    case ConsoleKey.G:
                        if (Ocktava == 1)
                        {
                            Console.Beep(PervaOcktava[4], 300);
                        }
                        if (Ocktava == 2)
                        {
                            Console.Beep(VtoraOcktava[4], 300);
                        }
                        break;
                    case ConsoleKey.H:
                        if (Ocktava == 1)
                        {
                            Console.Beep(PervaOcktava[4], 300);
                        }
                        if (Ocktava == 2)
                        {
                            Console.Beep(VtoraOcktava[4], 300);
                        }
                        break;
                }
        }
    }
    
}