namespace Episode018_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // Создаем экземпляр класса Random

            int randomNumber; // Генерируем случайное число

            int randomCounter = 0;

            while (randomCounter < 100)
            { 
                randomNumber = random.Next(1, 101);
                Console.WriteLine($"Итерация {randomCounter+1}. Случайное число: {randomNumber}");
                Thread.Sleep(500);
                randomCounter++;
            }
        }
    }
}
