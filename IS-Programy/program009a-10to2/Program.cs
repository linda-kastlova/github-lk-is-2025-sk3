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
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
        Console.Write("Nezadali jste přirozené číslo. Zadejte přirozené číslo v desítkové soustavě znovu: ");

    var mojePole = new uint[32];
    var zálohaNumber10 = number10;

    uint zbytek;

    uint i;
    for (i = 0; number10 > 0; i++)
    {
        zbytek = number10 % 2;
        number10 = (number10 - zbytek) / 2;
        mojePole[i] = zbytek;

        Console.WriteLine("Celá část = {0}; zbytek = {1}", number10, zbytek);
    }

    // Zpětný výpis pole
    Console.WriteLine("Desítkové číslo {0} ve dvojkové soustavě = ", zálohaNumber10);
    for (var j = i - 1; j >= 0; j--) Console.Write("{0}", mojePole[j]);


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}