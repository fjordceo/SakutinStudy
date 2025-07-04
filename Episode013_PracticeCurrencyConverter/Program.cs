namespace Episode013_PracticeCurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rublesInWallet;
            float dollarsInWallet;

            float rubToUsd = 75.0f; // Курс доллара к рублю
            float usdToRub = 0.013f; // Курс рубля к доллару

            int currentOpperation;
            int quantityToConvert;

            Console.Write("Введите количество рублей в кошельке: ");
            rublesInWallet = float.Parse(Console.ReadLine());

            Console.Write("Введите количество долларов в кошельке: ");
            dollarsInWallet = float.Parse(Console.ReadLine());

            Console.WriteLine("Добро пожаловать в конвертер валют!");
            Console.WriteLine("Доступные операции:");
            Console.WriteLine("1. Перевести доллары в рубли");
            Console.WriteLine("2. Перевести рубли в доллары");
            Console.Write("Выберите операцию:");
            

            currentOpperation = int.Parse(Console.ReadLine());

            switch (currentOpperation)
            {
                case 1:
                    Console.Write("Сколько долларов вы хотите перевести в рубли?: ");
                    quantityToConvert = int.Parse(Console.ReadLine());
                    if (quantityToConvert > dollarsInWallet)
                    {
                        Console.WriteLine("Недостаточно долларов в кошельке для перевода.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"У вас {dollarsInWallet} долларов, что эквивалентно {dollarsInWallet * rubToUsd} рублей.");
                        rublesInWallet += dollarsInWallet * rubToUsd;
                        dollarsInWallet -= quantityToConvert;
                        Console.WriteLine($"Теперь у вас {rublesInWallet} рулей, и {dollarsInWallet} долларов");
                    }
                    break;
                case 2:
                    Console.Write("Сколько рублей вы хотите перевести в доллары?: ");
                    quantityToConvert = int.Parse(Console.ReadLine());
                    if (quantityToConvert > rublesInWallet)
                    {
                        Console.WriteLine("Недостаточно рублей в кошельке для перевода.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"У вас {rublesInWallet} рублей, что эквивалентно {rublesInWallet * usdToRub} долларов.");
                        dollarsInWallet += rublesInWallet * usdToRub;
                        rublesInWallet -= quantityToConvert;
                        Console.WriteLine($"Теперь у вас {dollarsInWallet} долларов, и {rublesInWallet} рублей!");
                    }
                    break;
                default:
                    Console.WriteLine("Неверная операция. Пожалуйста, выберите 1 или 2.");
                    break;
            }
        }
    }
}
