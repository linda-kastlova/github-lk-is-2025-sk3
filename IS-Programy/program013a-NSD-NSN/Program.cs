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
    ulong numberA;
    while (!ulong.TryParse(Console.ReadLine(), out numberA))
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    
    Console.Write("Zadejte druhé celé číslo: ");
    ulong numberB;
    while (!ulong.TryParse(Console.ReadLine(), out numberB))
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    
    Console.WriteLine("První zadané číslo: {0}, druhé zadané číslo: {1}",  numberA, numberB);

    ulong A = numberA;
    ulong B = numberB;

    for (A <> B)
    {
       for(A > B) 
           
    }
    

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}