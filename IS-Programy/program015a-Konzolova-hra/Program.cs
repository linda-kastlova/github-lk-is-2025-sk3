/**
 * 1 - Bojovnik
 * 2 - Lucisnik
 * 3 - Carodej
 */
var characters = new int[] { 1, 2, 3 };
var charactersName = new String[] { "bojovnik", "lucisnik", "carodej" };
var charactersHealth = new int[] { 100, 75, 50 };
var charactersLightAttackDamage = new int[] { 5, 10, 15 };
var charactersLightAttackChance = new int[] { 100, 85, 80 };
var charactersBaseAttackDamage = new int[] { 7, 13, 17 };
var charactersBaseAttackChance = new int[] { 85, 60, 50 };
var charactersStrongAttackDamage = new int[] { 20, 15, 35 };
var charactersStrongAttackChance = new int[] { 60, 40, 25 };

var attacksName = new String[] { "lehky", "zakladni", "silny" };
var attackDamages = new int[][] { charactersLightAttackDamage, charactersBaseAttackDamage, charactersStrongAttackDamage };
var attackChances = new int[][] { charactersLightAttackChance, charactersBaseAttackChance, charactersStrongAttackChance };

var randomNames = new String[] { "Xavier", "Olaf", "Brumhilda", "Bonifac", "Radek", "Linda", "Ondrej", "Rostislav" };

var random = new Random();

while (true)
{
    int command = NumberCommandExit(2, "Menu:\n 3) Resetovat seed\n 2) Nastavit seed\n 1) Zahajit hru");

    if (command == 3)
    {
        random = new Random();
    }
    
    if (command == 2)
    {
        random = new Random(NumberCommand(0, int.MaxValue, "Zadej svuj seed: "));
    }
    
    if (command == 1)
    {
        string userName = TextCommand("Jmeno postavy: ");
        int userCharacter = NumberCommandExit(characters.Length, $"Specializace:\n 3) {charactersName[2]}\n 2) {charactersName[1]}\n 1) {charactersName[0]}") - 1;
        string userCharacterName = charactersName[userCharacter];
        int userHealthMax = charactersHealth[userCharacter];
        int userHealth = userHealthMax;
        
        string enemyName = randomNames[random.Next(0, randomNames.Length)];
        int enemyCharacter = random.Next(0, characters.Length);
        string enemyCharacterName = charactersName[enemyCharacter];
        int enemyHealthMax = charactersHealth[enemyCharacter];
        int enemyHealth = enemyHealthMax;
        
        Console.Clear();
        Console.WriteLine($"{userName} ({userCharacterName} {userHealth}HP) vs {enemyName} ({enemyCharacterName} {enemyHealth}HP)");

        while (userHealth > 0 && enemyHealth > 0)
        {
            int userAttack = NumberCommandExit(attacksName.Length,
             $"Zivoty: {userHealth}/{userHealthMax}" +
                     $"\n\nVyber typ utoku:" +
                     $"\n 1) {attacksName[0]} utok ({charactersLightAttackChance[userCharacter]}%) za {charactersLightAttackDamage[userCharacter]}HP" +
                     $"\n 2) {attacksName[1]} utok ({charactersBaseAttackChance[userCharacter]}%) za {charactersBaseAttackDamage[userCharacter]}HP" +
                     $"\n 3) {attacksName[2]} utok ({charactersStrongAttackChance[userCharacter]}%) za {charactersStrongAttackDamage[userCharacter]}HP"
            ) - 1;
            int userAttackChance = attackChances[userAttack][userCharacter];
            int userAttackDamage = attackDamages[userAttack][userCharacter];
            string userAttackName = attacksName[userAttack];
            bool doesUserHits = random.Next(0, 101) <= userAttackChance;
            
            int enemyAttack = random.Next(0, attacksName.Length - 1);
            int enemyAttackChance = attackChances[enemyAttack][enemyCharacter];
            int enemyAttackDamage = attackDamages[enemyAttack][enemyCharacter];
            string enemyAttackName = attacksName[enemyAttack];
            bool doesEnemyHits = random.Next(0, 101) <= enemyAttackChance;

            bool doesUserStarts = random.Next(0, 2) == 1;

            Console.WriteLine($"{userName} zvolil {userAttackName} ({userAttackChance}%) utok za {userAttackDamage}!");
            Console.WriteLine($"{enemyName} zvolil {enemyAttackName} ({enemyAttackChance}%) utok za {enemyAttackDamage}!");
            
            if (doesUserStarts)
            {
                if (doesUserHits)
                {
                    int nextHealth = enemyHealth - userAttackDamage;
                    
                    Console.WriteLine($"{userName} zasahl {enemyName}!");
                    Console.WriteLine($"{enemyHealth} - {userAttackDamage} = {nextHealth}");

                    enemyHealth = nextHealth;
                }
                else
                {
                    Console.WriteLine($"{userName} minul!");
                }
                
                if (doesEnemyHits && enemyHealth > 0)
                {
                    int nextHealth = userHealth - enemyAttackDamage;
                    
                    Console.WriteLine($"{enemyName} zasahl {userName}!");
                    Console.WriteLine($"{userHealth} - {enemyAttackDamage} = {nextHealth}");

                    userHealth = nextHealth;
                }
                else
                {
                    Console.WriteLine($"{enemyName} minul!");
                }
            }
            else
            {  
                if (doesEnemyHits)
                {
                    int nextHealth = userHealth - enemyAttackDamage;
                    
                    Console.WriteLine($"{enemyName} zasahl {userName}!");
                    Console.WriteLine($"{userHealth} - {enemyAttackDamage} = {nextHealth}");

                    userHealth = nextHealth;
                }
                else
                {
                    Console.WriteLine($"{enemyName} minul!");
                }
                
                if (doesUserHits && userHealth > 0)
                {
                    int nextHealth = enemyHealth - userAttackDamage;
                    
                    Console.WriteLine($"{userName} zasahl {enemyName}!");
                    Console.WriteLine($"{enemyHealth} - {userAttackDamage} = {nextHealth}");

                    enemyHealth = nextHealth;
                }
                else
                {
                    Console.WriteLine($"{userName} minul!");
                }
            }
            
            Console.WriteLine("Pro dalsi kolo zmackni enter...");
            Console.ReadLine();
        }

        bool doesUserWins = userHealth > 0;
        if (doesUserWins)
        {
            Console.WriteLine("Gratulujeme, vyhrál jsi!");
            Console.WriteLine();
            Console.WriteLine($"Hrac {userName} {userHealth}/{userHealthMax} porazil {enemyName} {enemyHealth}/{enemyHealthMax}!");
        }
        else
        {
            Console.WriteLine("Prohra! Zkus to znovu!");
            Console.WriteLine();
            Console.WriteLine($"Hrac {userName} {userHealth}/{userHealthMax} byl porazen {enemyName} {enemyHealth}/{enemyHealthMax}!");
        }
    }
    
    Console.WriteLine("Pro pokracovani zmackni enter...");
    Console.ReadLine();
}
static int NumberCommandExit(int max, string message)
{
    var input = NumberCommand(0, max, message + "\n 0) Konec");

    if (input == 0)
    {
        System.Environment.Exit(1);
    }

    return input;
}

static string TextCommand(string message)
{
    string? input = null;

    while (String.IsNullOrWhiteSpace(input))
    {
        Console.Clear();
        Console.WriteLine(message);
        input = Console.ReadLine();
    }

    return input.Trim();
}

static int NumberCommand(int min, int max, string message)
{
    int ?input = null;

    while (input == null || input < min || input > max)
    {
        Console.Clear();
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int value))
        {
            input = value;
        }
    }

    return (int) input;
}