/************************
 * Рахимов С.О          *
 * Дата : 13.02.2023    *
 * Базовые понятия С#   *
 * *********************/



using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите число a:");
            int.TryParse(Console.ReadLine(), out int Number);

            Console.Write("Введите число n:");
            int.TryParse(Console.ReadLine(), out int Degree);

            int Result = 1;

            for (int Step = 0; Step < Degree; ++Step)
            {
                Result *= Number;
            }

            Console.WriteLine($"{Number}^{Degree} = {Result}");

        }
    }
}
