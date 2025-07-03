namespace Episode002_ArithmeticOperations

/*
 * Арифметические операции в C#
 */



{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            // Арифметические операции в C#
            // Сложение +
            // Вычитание -
            // Умножение *
            // Деление /
            // Целочисленное деление //
            // Остаток от деления (Деление по модулю) %

            float result, modulResult;
            int a, b;

            a = 10;
            b = 3;
            result = (float)a / b;  // Приведение типов для получения дробного результата
            modulResult = a % b; // Остаток от деления
            result++; // Увеличиваем результат на 1
            result *= 2; // Умножаем результат на 2




            Console.WriteLine($"Переменная a = {a}");
            Console.WriteLine($"Переменная b = {b}");
            Console.WriteLine($"Результат деления {result}");
            Console.WriteLine($"Результат деления по модулю {modulResult}");

            // Время 29 минут


        }
    }
}
