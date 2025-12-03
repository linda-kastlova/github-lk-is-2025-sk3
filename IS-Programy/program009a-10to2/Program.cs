var again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************************************");
    Console.WriteLine("**** Převod z desítkové do binární (dvojkové) soustavy ****");
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

    var convertedNumbers = new uint[32];
    var converting = input;

    uint digitCount;
    for (digitCount = 0; converting > 0; digitCount++)
    {
        var remaining = converting % 2;
        converting = (converting - remaining) / 2;
        convertedNumbers[digitCount] = remaining;

        Console.WriteLine("Celá část = {0}; zbytek = {1}", input, remaining);
    }

    // Zpětný výpis pole
    Console.WriteLine("Desítkové číslo {0} ve dvojkové soustavě = ", input);
    for (var index = digitCount; index > 0; index--)
    {
        Console.Write("{0}", convertedNumbers[index - 1]);
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}