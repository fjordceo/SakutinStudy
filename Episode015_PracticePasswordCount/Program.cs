namespace Episode015_PracticePasswordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 5;
            string? password = "12345";
            string? inputPassword = null;

            for (int i = 0; i < tryCount; i++)
            {
                Console.Write("Введите пароль: ");
                inputPassword = Console.ReadLine();
                if (inputPassword == password)
                {
                    Console.WriteLine("Пароль верный! Доступ разрешен!");
                    break;
                }
                else
                {
                    Console.Write("Пароль неверный.");
                    Console.WriteLine($"Осталось попыток: {tryCount - i - 1}");
                    Console.WriteLine();
                    if (i == tryCount - 1)
                    {
                        Console.WriteLine("Вы исчерпали все попытки.");
                    }
                }
            }
        }
    }
}
