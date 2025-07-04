namespace Episode012_PracticePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "123qwe";
            string userInput;

            Console.Write("Введите пароль: ");
            userInput = Console.ReadLine();

            if (userInput == password)
            {
                Console.WriteLine("Пароль верный! Добро пожаловать!");
            }
            else
            {
                Console.WriteLine("Пароль неверный! Доступ запрещен!");
            }
        }
    }
}
