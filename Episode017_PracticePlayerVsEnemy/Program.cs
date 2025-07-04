namespace Episode017_PracticePlayerVsEnemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 100;
            int playerDamage = 10;
            int enemyHealth = 100;
            int enemyDamage = 15;

            while (playerHealth > 0 && enemyHealth > 0)
            {
                Console.WriteLine($"Игрок наносит {playerDamage} урона врагу. Здоровье врага: {enemyHealth - playerDamage}");
                enemyHealth -= playerDamage;
                if (enemyHealth <= 0)
                {
                    Console.WriteLine("Враг побежден!");
                    break;
                }
                Console.WriteLine($"Враг наносит {enemyDamage} урона игроку. Здоровье игрока: {playerHealth - enemyDamage}");
                playerHealth -= enemyDamage;
                if (playerHealth <= 0)
                {
                    Console.WriteLine("Игрок побежден!");
                    break;
                }
            }

        }
    }
}

// 2 часа 09 минут