namespace Episode005_ConvertTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=5, y=2;
            int age;
            float result;
            string input = "15";
            int trigger = 1;

            age = Convert.ToInt32(input); // Преобразование строки в целое число
            result = Convert.ToSingle(x) / Convert.ToSingle(y); // Преобразование целых чисел в вещественные числа (float)

            Console.WriteLine(Convert.ToBoolean(trigger));

            Console.WriteLine($"Ему было {age} лет!");
        }
    }
}
