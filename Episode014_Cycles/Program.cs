namespace Episode014_Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("Введите ваш возраст: ");

            age = Convert.ToInt32(Console.ReadLine());

            while (age-->0)
            {
                if (age == 10) // Пропускаем 10 лет
                {
                    continue;
                }
                Console.WriteLine($"С днем рождения! Вам {age}");
                if (age == 5)
                {
                    break;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 10;  i++)
            {
               Console.WriteLine($"Цикл for: {i}");
            }

            Console.WriteLine();





        }
    }
}
