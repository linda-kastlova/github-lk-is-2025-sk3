var again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************************************");
    Console.WriteLine("******** Převod z desítkové do jakékoliv soustavy *********");
    Console.WriteLine("***********************************************************");
    Console.WriteLine("********************** Linda Kastlová *********************");
    Console.WriteLine("************************ 27.11.2025 ***********************");
    Console.WriteLine("***********************************************************");
    Console.WriteLine();


    // Vstup číselné hodnoty do programu 
    Console.Write("Zadejte přirozené číslo v desítkové soustavě: ");
    uint input;
    while (!uint.TryParse(Console.ReadLine(), out input))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte přirozené číslo v desítkové soustavě znovu: ");
    }
    
    Console.Write("Zadejte cílovou soustu: ");
    uint targetNumberSystem;
    while (!uint.TryParse(Console.ReadLine(), out targetNumberSystem))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte přirozené číslo v desítkové soustavě znovu: ");
    }

    var convertedNumbers = new uint[32];
    var converting = input;

    uint digitCount;
    for (digitCount = 0; converting > 0; digitCount++)
    {
        var remaining = converting % targetNumberSystem;
        converting = (converting - remaining) / targetNumberSystem;
        convertedNumbers[digitCount] = remaining;

        Console.WriteLine("Celá část = {0}; zbytek = {1}", input, remaining);
    }

    // Zpětný výpis pole
    Console.WriteLine("Desítkové číslo {0} ve {1} soustavě = ", input, targetNumberSystem);
    for (var index = digitCount; index > 0; index--)
    {
        Console.Write("{0}", convertedNumbers[index - 1]);
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}