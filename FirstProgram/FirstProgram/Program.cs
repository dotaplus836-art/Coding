using System;

namespace FirstProgram
{
    class Program
    {
        private const int MinValue = 5;
        private const int MaxValue = 10;

        private static void Main(string[] args)
        {
            int number = ReadInput();
            PrintResult(number);

            Console.ReadKey();
        }

        private static int ReadInput()
        {
            int number;

            Console.Write("Введите число: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Ошибка ввода. Введите целое число: ");
            }

            return number;
        }

        private static void PrintResult(int number)
        {
            if (IsNumberInRange(number))
            {
                Console.WriteLine($"Число {number} больше {MinValue} и меньше {MaxValue}");
            }

            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }

        private static bool IsNumberInRange(int number)
        {
            return number > MinValue && number < MaxValue;
        }
    }
}