var again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*****************************************");
    Console.WriteLine("*********** Kombinovaná úloha ***********");
    Console.WriteLine("*****************************************");
    Console.WriteLine("************* Linda Kastlová ************");
    Console.WriteLine("*************** 10.12.2025 **************");
    Console.WriteLine("*****************************************");
    Console.WriteLine();


    // Vstup číselné hodnoty do programu 
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int input;
    while (!int.TryParse(Console.ReadLine(), out input)) Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");

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
    Console.WriteLine("Počet čísel: {0}, dolní mez: {1}, horní mez: {2}", input, lowerBound, upperBound);
    Console.WriteLine("===========================================");
    Console.WriteLine();

    
    var randomNumbers = new int[input];
    var myRandNumber = new Random();


    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");

    

    for (var i = 0; i < input; i++)
    {
        randomNumbers[i] = myRandNumber.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", randomNumbers[i]);

    }

    for (var i = 0; i < input - 1; i++)
    for (var j = 0; j < input - i - 1; j++)
    {
        if (randomNumbers[j] < randomNumbers[j + 1])
        {
            var tmp = randomNumbers[j + 1];
            randomNumbers[j + 1] = randomNumbers[j];
            randomNumbers[j] = tmp;
        }
    }
    
    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine("Seřazená pole:");
    for (var i = 0; i < input; i++) Console.Write("{0}; ", randomNumbers[i]);

   
    Console.WriteLine();
    
    var secondBiggest = randomNumbers[1];
    Console.WriteLine("Druhé největší číslo: {0} ",  secondBiggest);

    var thridBiggest = randomNumbers[2];
    Console.WriteLine("Třetí největší číslo: {0}",  thridBiggest);
    
    var fourthBiggest = randomNumbers[3];
    Console.Write("Čtvrté největší číslo: {0}",  fourthBiggest);
    
    Console.WriteLine();
    
    var isEven = input % 2 == 0;
    var half = (int) Math.Round((double) input / 2);
    var median = 0;
    
    if (isEven)
    {
        var first = randomNumbers[half];
        var second = randomNumbers[half - 1];
        
        median = (int) Math.Round(((double)first + second) / 2);
    }
    else
    {
        median =  randomNumbers[half - 1];
    }
    
    Console.WriteLine("Medián je {0} z celkového {1} počtu čísel {2}", median, isEven ? "sudého" : "lichého", input);
    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}