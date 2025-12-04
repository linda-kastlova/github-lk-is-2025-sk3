using System.Diagnostics;

var again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*****************************************");
    Console.WriteLine("********** Vykreslování šipky ***********");
    Console.WriteLine("*****************************************");
    Console.WriteLine("************* Linda Kastlová ************");
    Console.WriteLine("*************** 03.12.2025 **************");
    Console.WriteLine("*****************************************");
    Console.WriteLine();
    
    int lowerBound = 3;
    int upperBound = 100;
    int input;
    
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    while (!int.TryParse(Console.ReadLine(), out input) || input <= lowerBound || input >= upperBound)
    {
        Console.Write("Nezadali jste platné číslo v rozmezí {O} a {1}. Zadejte číslo znovu: ", lowerBound, upperBound);
    }
    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine("Počet čísel: {0}", input);
    
    Random randomGenerator = new Random(); 
    int[] randomNumbers = new int[input];
    int suma = 0;

    for (int i = 0; i < input; i++)
    {
        randomNumbers[i] = randomGenerator.Next(1, 11);
        Console.WriteLine("Vygeneráváno náhodné číslo: {0}; ", randomNumbers[i]);
     
        suma += randomNumbers[i];
    }
    
    int average = (int) Math.Round((float) suma / input);
    int width = average;
    int height = width;
    int gap = Math.Max((int)Math.Round((decimal) height / 4), 2);
    int arrowWidth = width + gap;
    int arrowHeight = (int) Math.Round((decimal) arrowWidth / 2);
    
        
    for (int row = 0; row < arrowHeight; row++)
    {
        int left = arrowHeight - (row + 1);
        int right = arrowHeight - (row + 1);

        for (int column = 0; column < arrowWidth; column++)
        {
            if (column < arrowHeight)
            {
                if (column + 1 > left)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            else
            {
                if (column < arrowWidth - right)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
        }
        Console.WriteLine();
    }
    
    for (int row = 0; row < height; row++)
    {
        for (int column = 0; column < arrowWidth; column++)
        
            if(column >= gap && column < width)
                Console.Write("* ");
            else
                Console.Write("  ");
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}