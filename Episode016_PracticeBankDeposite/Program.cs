namespace Episode016_PracticeBankDeposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float depositValue; // Начальная сумма депозита
            int depositPeriod;
            int depositPercent = 10; // Процентная ставка

            Console.Write("Введите количество денег на вкладе: ");
            depositValue = Convert.ToSingle(Console.ReadLine());

            Console.Write("На сколько лет открыт вклад?: ");
            depositPeriod = Convert.ToInt32(Console.ReadLine());

            Console.Write("Под какой процент?: ");
            depositPercent = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= depositPeriod; i++)
            {
                depositValue += depositValue * depositPercent / 100;
                Console.WriteLine($"Через {i} год(а/ов) на вашем счету будет: {depositValue}");
                
                Console.ReadKey();
            }

        }
    }
}

// 2 часа 03 минуты