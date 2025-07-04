namespace Episode011_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ? dayOfWeek;
            Console.Write("Введите день недели: ");
            dayOfWeek = Console.ReadLine();



            // Пример использования оператора switch
            switch (dayOfWeek)
            {
                case "понедельник":
                case "суббота":
                case "воскресенье":
                    Console.WriteLine("Идем в кино!");
                    Console.WriteLine("Едим в попкорн!");
                    break;
                case "вторник":
                    Console.WriteLine("Занимаемся программированием!");
                    break;
                case "среда":
                    Console.WriteLine("Середина недели, чтоб ее!");
                    break;
                case "четверг":
                    Console.WriteLine("Проектируем приложение");
                    break;
                case "пятница":
                    Console.WriteLine("Полнейший чиллллл");
                    break;
                default:
                    Console.WriteLine("Неизвестный день недели!");
                    Console.WriteLine("Пожалуйста, введите корректный день недели.");
                    break;
            }   
        }
    }
}
