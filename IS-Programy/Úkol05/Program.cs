var again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*****************************************");
    Console.WriteLine("**** Generátor pseudonáhodných čísel ****");
    Console.WriteLine("*****************************************");
    Console.WriteLine("************* Linda Kastlová ************");
    Console.WriteLine("*************** 06.11.2025 **************");
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


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}