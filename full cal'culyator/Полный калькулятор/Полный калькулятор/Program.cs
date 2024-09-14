using System;

namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Выход");

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    break; // Выход из программы
                }

                Console.WriteLine("Введите первое число:");
                double number1 = GetValidNumber();

                Console.WriteLine("Введите второе число:");
                double number2 = GetValidNumber();

                double result = 0;

                switch (choice)
                {
                    case "1":
                        result = number1 + number2;
                        Console.WriteLine($"Результат сложения: {result}");
                        break;
                    case "2":
                        result = number1 - number2;
                        Console.WriteLine($"Результат вычитания: {result}");
                        break;
                    case "3":
                        result = number1 * number2;
                        Console.WriteLine($"Результат умножения: {result}");
                        break;
                    case "4":
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                            Console.WriteLine($"Результат деления: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: делитель не может быть равен нулю.");
                        }
                        break;
                    default:
                        Console.WriteLine("Недопустимый выбор. Пожалуйста, попробуйте снова.");
                        break;
                }

                Console.WriteLine(); // Для разделения результатов
            }
        }

        static double GetValidNumber()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите число:");
            }
            return number;
        }
    }
}
