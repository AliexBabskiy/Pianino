 using System;
class Pianino
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать. Нажмите на Enter клавишу для запуска.\n");
        while (true)
        {
            ConsoleKeyInfo keye = Console.ReadKey();
            if (keye.Key == ConsoleKey.Enter)
            {
                break;
            }
        }
        Console.WriteLine("Для переключения октав используйте клавиши F3 F4 F5 \nДля проигрывания нот используйте клавиши Q W E R A S D F Z X C V");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.F3) 
            {
                Zvuk3();
            }

            if (key.Key == ConsoleKey.F4)
            {
                Zvuk4();
            }

            if (key.Key == ConsoleKey.F5)
            {
                Zvuk5();
            }

            if (key.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("ЕЕсли хотите выйти повторно нажмите Escape"); // пришлось вставить вторую букву в начале так как он её почемуто уберает даже если поставить несколько пробелов
                ConsoleKeyInfo key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.Escape)
                {
                    return;
                }
            }
        }
    }
    
    static void Zvuk3()
    {
        Console.WriteLine("Третья октава");
        int i = 1;
        int[] Octave3 = new int[11] { 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
        do
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Q)
            {
                Console.Beep(Octave3[i], 800);
                i++;
            }
            else if (key.Key == ConsoleKey.W)
            {
                Console.Beep(Octave3[i], 800);
                i++;
            }
            else if (key.Key == ConsoleKey.E)
            {
                Console.Beep(Octave3[i], 800);
                i++;
            }
            else if (key.Key == ConsoleKey.R)
            {
                Console.Beep(Octave3[i], 800);
                i++;
            }
            else if (key.Key == ConsoleKey.A)
            {
                Console.Beep(Octave3[i], 800);
                i++;
            }
            else if (key.Key == ConsoleKey.S)
            {
                Console.Beep(Octave3[i], 800);
                i++;
            }
            else if (key.Key == ConsoleKey.D)
            {
                Console.Beep(Octave3[i], 800);
                i++;
            }
            else if (key.Key == ConsoleKey.F)
            {
                Console.Beep(Octave3[i], 800);
                i++;
            }
            else if (key.Key == ConsoleKey.Z)
            {
                Console.Beep(Octave3[i], 800);
                i++;
            }
            else if (key.Key == ConsoleKey.X)
            {
                Console.Beep(Octave3[i], 800);
                i++;
            }   
            else if (key.Key == ConsoleKey.C)
            {
                Console.Beep(Octave3[i], 800);
                i++;
            }
            else if (key.Key == ConsoleKey.V)
            {
                Console.Beep(Octave3[i], 800);
                i++;
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                return;
            }
        }
        while (i < 12);
    }
    static void Zvuk4()
    {
        Console.WriteLine("Четвёртая октава");
        int i = 1;
        int[] Octave4 = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
        do
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Q)
            {
                Console.Beep(Octave4[i], 800);
            }
            if (key.Key == ConsoleKey.W)
            {
                Console.Beep(Octave4[i], 800);
            }
            if (key.Key == ConsoleKey.E)
            {
                Console.Beep(Octave4[i], 800);
            }
            if (key.Key == ConsoleKey.R)
            {
                Console.Beep(Octave4[i], 800);
            }
            if (key.Key == ConsoleKey.A)
            {
                Console.Beep(Octave4[i], 800);
            }
            if (key.Key == ConsoleKey.S)
            {
                Console.Beep(Octave4[i], 800);
            }
            if (key.Key == ConsoleKey.D)
            {
                Console.Beep(Octave4[i], 800);
            }
            if (key.Key == ConsoleKey.F)
            {
                Console.Beep(Octave4[i], 800);
            }
            if (key.Key == ConsoleKey.Z)
            {
                Console.Beep(Octave4[i], 800);
            }
            if (key.Key == ConsoleKey.X)
            {
                Console.Beep(Octave4[i], 800);
            }
            if (key.Key == ConsoleKey.C)
            {
                Console.Beep(Octave4[i], 800);
            }
            if (key.Key == ConsoleKey.V)
            {
                Console.Beep(Octave4[i], 800);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                return;
            }
            i++;
        }
        while (i < 12);
    }
    static void Zvuk5()
    {
        Console.WriteLine("Пятая октава");
        int i = 1;
        int[] Octave5 = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
        do
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Q)
            {
                Console.Beep(Octave5[i], 800);
            }
            if (key.Key == ConsoleKey.W)
            {
                Console.Beep(Octave5[i], 800);
            }
            if (key.Key == ConsoleKey.E)
            {
                Console.Beep(Octave5[i], 800);
            }
            if (key.Key == ConsoleKey.R)
            {
                Console.Beep(Octave5[i], 800);
            }
            if (key.Key == ConsoleKey.A)
            {
                Console.Beep(Octave5[i], 800);
            }
            if (key.Key == ConsoleKey.S)
            {
                Console.Beep(Octave5[i], 800);
            }
            if (key.Key == ConsoleKey.D)
            {
                Console.Beep(Octave5[i], 800);
            }
            if (key.Key == ConsoleKey.F)
            {
                Console.Beep(Octave5[i], 800);
            }
            if (key.Key == ConsoleKey.Z)
            {
                Console.Beep(Octave5[i], 800);
            }
            if (key.Key == ConsoleKey.X)
            {
                Console.Beep(Octave5[i], 800);
            }
            if (key.Key == ConsoleKey.C)
            {
                Console.Beep(Octave5[i], 800);
            }
            if (key.Key == ConsoleKey.V)
            {
                Console.Beep(Octave5[i], 800);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                return;
            }
            i++;
        }
        while (i < 12);
    }
}