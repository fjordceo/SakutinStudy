namespace Episode006_ConsoleInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine(); // Считывание строки с консоли
            Console.WriteLine($"Привет, {name}!"); // Вывод строки на консоль
            Console.Write("Введите ваш возраст: ");
            age = int.Parse(Console.ReadLine()); // Считывание числа с консоли
            Console.WriteLine($"Вам {age} лет!");
        }
    }
}
