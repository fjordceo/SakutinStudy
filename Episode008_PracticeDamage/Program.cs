namespace Episode008_PracticeDamage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float health; 
            int armor;
            int damage;
            int percentConverter = 100; // Константа для конвертации процентов в целое число

            Console.Write("Ввелите количество здоровья: ");
            health = int.Parse(Console.ReadLine());
            
            Console.Write("Ввелите количество брони: ");
            armor = int.Parse(Console.ReadLine());

            Console.Write("Ввелите количество урона: ");
            damage = int.Parse(Console.ReadLine());

            Console.WriteLine();

            health -= Convert.ToSingle(damage)/percentConverter*armor;

            Console.WriteLine($"Вам нанесли {damage} урона. У вас осталось {health} здоровья");


        }
    }
}
