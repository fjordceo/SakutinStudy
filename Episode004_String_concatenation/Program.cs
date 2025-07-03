namespace Episode004_String_concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 38;



            string greeting = "Hello";
            string name = "Mikhail";
            string massage = greeting + ", " + name + "!"; // Конкатенация строк с помощью оператора +

            Console.WriteLine(massage);
            Console.WriteLine("Завтра тебе исполнится " + age +" лет!");
            Console.WriteLine($"А через год тебе исполнится {age + 1} лет!"); // Конкатенация строк с помощью интерполяции строк

          
        }
    }
}
