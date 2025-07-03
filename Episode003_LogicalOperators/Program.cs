namespace Episode003_LogicalOperators

/*
 * Логические операторы в C#
 */



{
    internal class Program
    {
        static void Main(string[] args)
        {
            // == оператор сравнения на равенство
            // != оператор сравнения на неравенство
            // > оператор сравнения на больше
            // < оператор сравнения на меньше
            // >= оператор сравнения на больше или равно
            // <= оператор сравнения на меньше или равно
            // && логическое И (AND)
            // || логическое ИЛИ (OR)
            // ! логическое НЕ (NOT)
            // ^ логическое исключающее ИЛИ (XOR)

            int age = 18;
            bool accesIsAllowed = false;

            accesIsAllowed = age >= 18 && age <= 60; // Проверка на возраст от 18 до 60 включительно
            Console.WriteLine($"Access is Allowed: {accesIsAllowed}");


        }
    }
}
