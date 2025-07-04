namespace Episode019_PracticeGuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int userGuess;
            int triesCount = 5;

            while (triesCount > 0)
            {
                triesCount--;
                Console.Write("Угадайте число от 1 до 10: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out userGuess))
                {

                    int randomNumber = random.Next(1, 11);
                    if (userGuess < 1 || userGuess > 10)
                    {
                        Console.WriteLine("Пожалуйста, введите число от 1 до 10.");
                        continue;
                    }
                    if (userGuess == randomNumber)
                    {
                        Console.WriteLine("Поздравляем! Вы угадали число!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неправильно. Попробуйте еще раз.");
                        Console.WriteLine($"У вас осталось {triesCount} попыток");
                        Console.WriteLine($"Загаданное число было: {randomNumber}");
                    }
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите корректное число.");
                }
            }
        }
    }
}

// 2 часа 21 минута