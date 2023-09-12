using System;

namespace Mod_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 9;

            Console.WriteLine("Таблица умножения на " + number + ":");

            for (int i = 1; i <= 9; i++)
            {
                int result = number * i;
                Console.WriteLine(number + " x " + i + " = " + result);
            }
        }
    }
}