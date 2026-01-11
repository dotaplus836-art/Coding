using System;

namespace FirstProgram
{
    class Test
    {
        private static void Main()
        {
            Console.Write("Введите число: ");

            if (int.TryParse(Console.ReadLine(), out int userInputNumber))
            {
                if (userInputNumber > 5 && userInputNumber < 10)
                {
                    Console.WriteLine($"Число {userInputNumber} больше 5 и меньше 10");
                }
                    
                else
                {
                    Console.WriteLine("Неизвестное число");
                }
            }

            else
            {
                Console.WriteLine("Ошибка ввода в консоль......"); Console.ReadKey();
            }
        }

    }
}