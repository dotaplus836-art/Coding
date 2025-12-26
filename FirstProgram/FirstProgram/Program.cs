using System;

namespace FirstProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int secondNumber = int.Parse(Console.ReadLine());

            CompareNumbers(firstNumber, secondNumber);
        }

        private static void CompareNumbers(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
                Console.WriteLine($"{firstNumber} > {secondNumber}");
            else if (firstNumber < secondNumber)
                Console.WriteLine($"{firstNumber} < {secondNumber}");
            else
                Console.WriteLine($"{firstNumber} == {secondNumber}");
        }
    }
}