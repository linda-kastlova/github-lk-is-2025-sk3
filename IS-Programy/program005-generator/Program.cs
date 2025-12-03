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

    //Rozdělování na kladná, záporná a nuly
    var positiveNumbers = 0;
    var negativeNumbers = 0;
    var zeros = 0;

    //Rozdělování na sudá a lichá čísla
    var evenNumbers = 0;
    var oddNumbers = 0;

    for (var i = 0; i < n; i++)
    {
        myRandNumbers[i] = myRandNumber.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandNumbers[i]);

        //Kladná a záporná čísla a nuly
        /*if(myRandNumbers[i] > 0)
            positiveNumbers++;
        if (myRandNumbers[i] < 0)
            negativeNumbers++;
        if (myRandNumbers[i] == 0)
            zeros++;*/

        if (myRandNumbers[i] > 0)
            positiveNumbers++;
        else if (myRandNumbers[i] < 0)
            negativeNumbers++;
        else zeros++;

        //Sudá a lichá čísla
        if (myRandNumbers[i] % 2 == 0)
            evenNumbers++;
        else oddNumbers++;
    }

    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine("===========================================");
    Console.WriteLine("Počet záporných čísel: {0}", negativeNumbers);
    Console.WriteLine("Počet kladných čísel: {0}", positiveNumbers);
    Console.WriteLine("Počet nul: {0}", zeros);
    Console.WriteLine("===========================================");
    Console.WriteLine("Počet sudých čísel: {0}", evenNumbers);
    Console.WriteLine("Počet lichých čísel: {0}", oddNumbers);
    Console.WriteLine("===========================================");
    Console.WriteLine("===========================================");


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}