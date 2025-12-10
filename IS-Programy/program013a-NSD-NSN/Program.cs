var again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("********** NSD a NSN **********");
    Console.WriteLine("*******************************");
    Console.WriteLine("******** Linda Kastlová *******");
    Console.WriteLine("********** 09.12.2025 *********");
    Console.WriteLine("*******************************");
    Console.WriteLine();


    // Vstup číselné hodnoty do programu 
    Console.Write("Zadejte první celé číslo: ");
    ulong inputFirst;
    while (!ulong.TryParse(Console.ReadLine(), out inputFirst))
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    
    Console.Write("Zadejte druhé celé číslo: ");
    ulong inputSecond;
    while (!ulong.TryParse(Console.ReadLine(), out inputSecond))
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    
    Console.WriteLine("První zadané číslo: {0}, druhé zadané číslo: {1}",  inputFirst, inputSecond);

    int iterations = 0;
    ulong first = inputFirst;
    ulong second = inputSecond;
    
    while (first != second)
    {
        iterations++;
        
        if (first > second)
        {
            first = first - second;
            Console.WriteLine("Krok {0}: První číslo {1} - druhé číslo {2}", iterations, first, second);
        }
        else
        {
            second = second - first;
            Console.WriteLine("Krok {0}: Druhé číslo {1} - první číslo {2}", iterations, second, first);
        }
    }    
    Console.WriteLine("=============================================");
    Console.WriteLine("Největší společný dělitel je číslo {0}", first);

    ulong leastCommonMultiple = (inputFirst * inputSecond) / first;
        
    Console.WriteLine("Nejmenší společný násobek je {0}", leastCommonMultiple);
    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}