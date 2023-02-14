using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Введите число:");

            string Number = Console.ReadLine();

            Number = (Number + Number[1]).Remove(1, 1);

            Console.WriteLine(Number);


            /*String Number, NewNumber = "";

            Console.Write("Введите число:");

            Number = Console.ReadLine();

            for (int Step = 0; Step < Number.Length; Step++)
            {
                if (Step == 1)
                {
                    continue;
                }
                NewNumber += Number[Step];
            }

            NewNumber += Number[1];

            Console.WriteLine(NewNumber);*/
        }
    }
}
