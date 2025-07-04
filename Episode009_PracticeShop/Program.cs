namespace Episode009_PracticeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int foodRequest;
            int foodUnitPrice = 10; // Цена за единицу еды
            bool isAbleToPay;

            Console.WriteLine($"Добро пожаловать в пекарню! Сегодня еда по {foodUnitPrice} монет!");
            Console.Write("Сколько у вас золота?: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы можете купить {money/foodUnitPrice} единиц еды");
            Console.Write("Сколько единиц еды вы хотите купить?: ");
            foodRequest = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = money >= foodRequest * foodUnitPrice; 

            if (!isAbleToPay)
            {
                Console.WriteLine("Вы не можете купить столько еды, у вас денег не хватает!!");
                return;
            }
            else
            {
                money -= foodRequest * foodUnitPrice; // Вычитаем стоимость еды из денег
                Console.WriteLine($"У вас осталось {money} монет! Но зато теперь у вас есть {foodRequest} единиц еды!");
            }



        }
    }
}

// 1 час 06 минут 
