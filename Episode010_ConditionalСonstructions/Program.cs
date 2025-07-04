namespace Episode010_ConditionalСonstructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("Введите ваш возраст!: ");
            age = int.Parse(Console.ReadLine());
            


            if (age >= 18)
            { 
                Console.WriteLine("Добро пожаловать в клуб!");
                Console.WriteLine("Что будете пить?");
            }
            else
            {
                Console.WriteLine("Доступ в клуб запрещен!");
                Console.WriteLine($"Приходите к нам через {18-age} лет");
            }

            int money = 500;
            int level = 10;

            if (money >= 500 || level > 9)
            {
                Console.WriteLine("Проходи! Добро пожаловать в нашу гильдию!");
            }
            else
            {
                Console.WriteLine("Извини, но ты не можешь вступить в нашу гильдию!");
            }






        }

        // Логический оператор && (логическое И) и || (логическое ИЛИ) позволяют комбинировать условия
        // Логическое И (&&) возвращает true, если оба условия истинны
        // Логическое ИЛИ (||) возвращает true, если хотя бы одно из условий истинно

       

        


    }
}

// 1 час 24 минуты