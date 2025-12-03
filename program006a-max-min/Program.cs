var again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*****************************************");
    Console.WriteLine("*********** Maximum a minimum ***********");
    Console.WriteLine("*****************************************");
    Console.WriteLine("************* Linda Kastlová ************");
    Console.WriteLine("*************** 13.11.2025 **************");
    Console.WriteLine("*****************************************");
    Console.WriteLine();


    // Vstup číselné hodnoty do programu 
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n)) Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");

    Console.Write("Zadejte dolní mez generovaných čísel (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");

    Console.Write("Zadejte horní mez generovaných čísel (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");

    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}, dolní mez: {1}, horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("===========================================");
    Console.WriteLine();

    //Deklarace pole - uložiště čísel
    var myRandNumbers = new int[n];

    //Příprava pro generování náhodných čísel
    //Random myRandNumber = new Random(); 
    var myRandNumber = new Random(25);


    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");


    for (var i = 0; i < n; i++)
    {
        myRandNumbers[i] = myRandNumber.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandNumbers[i]);
    }


    // Hledání maxima, pozice maxima, minima a pozice minima
    var max = myRandNumbers[0];
    var min = myRandNumbers[0];
    var posMax = 0;
    var posMin = 0;

    for (var i = 1; i < n; i++)
    {
        if (myRandNumbers[i] > max)
        {
            max = myRandNumbers[i];
            posMax = i;
        }

        if (myRandNumbers[i] < min)
        {
            min = myRandNumbers[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice minima: {posMin}");
    Console.WriteLine("===========================================");

    // Vykreslení přesýpacích hodin
    if (max >= 3)
    {
        Console.WriteLine();
        Console.WriteLine("============================================");
        Console.WriteLine();
        Console.WriteLine($"Přesýpací hodiny o velikosti {max}:");
        Console.WriteLine();

        //Tento cyklus se stará o to, aby se vykreslil správný počet řádků
        for (var i = 0; i < max; i++)
        {
            int spaces, stars;
            if (i < max / 2)
            {
                //horní polovina obrazce - Určit počet mezer  
                spaces = i;
                //horní polovina obrazce - Určit počet hvězdiček - s každým dalším řádkem ubývají 2 hvězdičky
                stars = max - 2 * i;
            }
            else
            {
                //dolní polovina obrazce - Určit počet mezer
                spaces = max - i - 1;
                //dolní polovina obrazce - Určit počet hvězdiček
                if (max % 2 == 1)
                    stars = 2 * (i - max / 2) + 1;
                else
                    stars = 2 * (i - max / 2) + 2;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            // Vykreslení správného počtu mezer pro každý řádek
            // sp - space (1 mezera
            for (var sp = 0; sp < spaces; sp++)
                Console.Write("  ");
            Console.WriteLine();
            // Vykreslení správného počtu hvězdiček pro každý řádek
            // st - stars (1 hvězdička)
            for (var st = 1; st < stars; st++)
                Console.Write("*");
            Console.WriteLine();
        }

        Console.ResetColor();
    }
    else
    {
        Console.WriteLine("Maximum je menší než 3 ==> obrazec se nebude vykreslovat.");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}