namespace Episode007_incrementAndDecrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int test = 0;
            number++; // Увеличение на 1. Инкремент
            number--; // Уменьшение на 1. Декремент

            ++number; // Префиксный инкремент
            --number; // Префиксный декремент

            Console.WriteLine($"Постфиксный инкремент от нуля: {test++}");
            test = 0; // Сброс значения для демонстрации

            Console.WriteLine($"Постфиксный декремент от нуля: {test--}");
            test = 0; // Сброс значения для демонстрации

            Console.WriteLine($"Префиксный инкремент от нуля: {++test}");
            test = 0; // Сброс значения для демонстрации

            Console.WriteLine($"Префиксный декремент от нуля: {--test}");
            test = 0; // Сброс значения для демонстрации
        }
    }
}

// 57 минут

