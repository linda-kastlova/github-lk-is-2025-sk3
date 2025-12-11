var again = "a";
while (again == "a")
{
    Console.Clear();

    // volání metody
    razitko();
    ulong a = vypisHodnoty("Zadejte přirozené číslo A: ");
    ulong b = vypisHodnoty("Zadejte přirozené číslo B: ");
    ulong nsd = vypocetNSD(a,b);
    ulong nsn = vypocetNSN(a, b, nsd);
    zobrazeniVysledku(a, b, nsd, nsn);
    

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}

//Deklarace metody
static void razitko()
{
    Console.WriteLine("*******************************");
    Console.WriteLine("********** NSD a NSN **********");
    Console.WriteLine("*******************************");
    Console.WriteLine("******** Linda Kastlová *******");
    Console.WriteLine("********** 11.12.2025 *********");
    Console.WriteLine("*******************************");
    Console.WriteLine();
}

static ulong vypisHodnoty(string zprava)
{
    Console.Write(zprava);
    ulong input;
    while (!ulong.TryParse(Console.ReadLine(), out input))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte vstup znovu: ");
    }
    return input;
}

static ulong vypocetNSD(ulong numberA, ulong numberB)
{
    while (numberA != numberB)
    {
        if (numberA > numberB)
            numberA = numberA - numberB;
        else
            numberB = numberB - numberA;
    }
    return numberA;
}

static void zobrazeniVysledku(ulong a, ulong b, ulong nsd, ulong nsn)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("První zadané číslo {0}, druhé zadané číslo {1}; jejich největší společný dělitel je: {2}", a, b, nsd);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine();
    Console.Write("První zadané číslo {0}, druhé zadané číslo {1}; jejich nejmenší společný násobek je: {2}", a, b, nsn);
    Console.ResetColor();
}

static ulong vypocetNSN(ulong a, ulong b, ulong nsd)
{
    return (a * b) / nsd;
}