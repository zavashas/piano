namespace ConsoleApp18
{
    class Program
    {
        static int[] octave5 = new int[] { 554, 622, 740, 830, 932, 523, 587, 659, 698, 784, 880, 987 };
        static int[] octave6 = new int[] { 1109, 1245, 1480, 1661, 1865, 1047, 1175, 1319, 1397, 1568, 1760, 1976 };
        static int[] nowOctave;

        static void Main()
        {
            Console.WriteLine("Переключение между октавами - F5 и F6");
            nowOctave = octave5;

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.F5)
                {
                    nowOctave = octave5;
                    Console.WriteLine("5 октава");
                }
                else if (key.Key == ConsoleKey.F6)
                {
                    nowOctave = octave6;
                    Console.WriteLine("6 октава");
                }

                PlaySound(key.Key);
            }
        }

        static void PlaySound(ConsoleKey key)
        {
            if (key == ConsoleKey.S)
                Console.Beep(nowOctave[0], 300);
            else if (key == ConsoleKey.D)
                Console.Beep(nowOctave[1], 300);
            else if (key == ConsoleKey.F)
                Console.Beep(nowOctave[2], 300);
            else if (key == ConsoleKey.G)
                Console.Beep(nowOctave[3], 300);
            else if (key == ConsoleKey.H)
                Console.Beep(nowOctave[4], 300);
            else if (key == ConsoleKey.J)
                Console.Beep(nowOctave[5], 300);
            else if (key == ConsoleKey.K)
                Console.Beep(nowOctave[6], 300);
            else if (key == ConsoleKey.E)
                Console.Beep(nowOctave[7], 300);
            else if (key == ConsoleKey.R)
                Console.Beep(nowOctave[8], 300);
            else if (key == ConsoleKey.T)
                Console.Beep(nowOctave[9], 300);
            else if (key == ConsoleKey.Y)
                Console.Beep(nowOctave[10], 300);
            else if (key == ConsoleKey.U)
                Console.Beep(nowOctave[11], 300);
        }
    }
}