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

    var max = randomNumbers[0];
    var min = randomNumbers[0];
    
    var maxHits = 0;
    var minHits = 0;
    
    var maxPositions = new int[input];
    var minPositions = new int[input];
    
    for (var i = 1; i < input; i++)
    {
        var currentNumber = randomNumbers[i];
        
        if (currentNumber > max)
        {
            maxPositions = new int[input];
            maxHits = 0;
            
            max = currentNumber;
            
            maxPositions[maxHits] = i;
            maxHits++;
        } else if (currentNumber == max)
        {
            maxPositions[maxHits] = i;
            maxHits++;
        }

        if (currentNumber < min)
        {
            minPositions = new int[input];
            minHits = 0;
            
            min = currentNumber;
            
            minPositions[minHits] = i;
            minHits++;
        }else if (currentNumber == min)
        {
            minPositions[minHits] = i;
            minHits++;
        }
    }
    
    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine($"Maximum: {max}, všechny pozice maxima: ");
    for (int i = 0; i < maxHits; i++)
    {
        Console.Write($"{maxPositions[i]}; ");
    }
    Console.WriteLine();
    Console.WriteLine($"Minimum: {min}, všechny pozice minima: ");
    for (int i = 0; i < minHits; i++)
    {
        Console.Write($"{minPositions[i]}; ");
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

    int uniqueCount = 0;
    int lastValue = int.MinValue;
    int secondBiggest = 0;
    int thirdBiggest = 0;
    int fourthBiggest = 0;

    for (int i = 0; i < input; i++)
    {
        if(randomNumbers[i] != lastValue)
        {
            uniqueCount++;
            lastValue = randomNumbers[i];

            if (uniqueCount == 2)
            {
                secondBiggest = randomNumbers[i];
            }
            if (uniqueCount == 3)
            {
                thirdBiggest = randomNumbers[i];
            }
            if (uniqueCount == 4)
            {
                fourthBiggest = randomNumbers[i];
            }
        }
    }
   
    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine("Druhé největší číslo: {0} ",  secondBiggest);
    Console.WriteLine("Třetí největší číslo: {0}",  thirdBiggest);
    Console.WriteLine("Čtvrté největší číslo: {0}",  fourthBiggest);
    
    Console.WriteLine();
    
    var isEven = input % 2 == 0;
    var half = (int) Math.Round((double) input / 2);
    var median = 0;
    
    if (isEven)
    {
        var first = randomNumbers[half];
        var  secondNumberMedian = randomNumbers[half - 1];
        
        median = (int) Math.Round(((double)first +  secondNumberMedian) / 2);
    }
    else
    {
        median =  randomNumbers[half - 1];
    }
    
    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine("Medián je: {0}", median);

    string binary = "";
    int transferredNumber = fourthBiggest;

    if (transferredNumber == 0) binary = "0";
    while (transferredNumber > 0)
    {
        binary = (transferredNumber % 2) + binary;
        transferredNumber /= 2;
    }
    
    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine($"Čtvrté největší číslo v binární soustavě: {fourthBiggest} = {binary}");
    
    Console.WriteLine();
    Console.WriteLine("===========================================");

    int height = median;
    int width = thirdBiggest;
    
    Console.WriteLine($"Obrazec - výška = medián {height}; šířka = třetí největší číslo {width}");
    Console.WriteLine();

    int part = height / 3;
    int evenWidth;
    int indent;

    if (width % 2 == 0)
    {
        evenWidth = 2;
        indent = (width - 2) / 2;
    }
    else
    {
        evenWidth = 3;
        indent = (width - 3) / 2;
    }

    for (int i = 0; i < height; i++)
    {
        if (i < part)
        {
            for(int space = 0; space < indent; space++)
                Console.Write("  ");
            
            for(int star = 0; star < evenWidth; star++)
                Console.Write("* ");
            
            Console.WriteLine();
        }
        
        else if (i < height - part)
        {
            for(int row = 0; row < width; row++)
                Console.Write("* ");
            
            Console.WriteLine();
            
        }
        else
        {
            for(int space = 0; space < indent; space++)
                Console.Write("  ");
            
            for(int star = 0; star < evenWidth; star++)
                Console.Write("* ");
            
            Console.WriteLine();
            
        }
    }
    
    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}