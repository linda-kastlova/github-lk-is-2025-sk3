var again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("********* Výpočet PI **********");
    Console.WriteLine("*******************************");
    Console.WriteLine("******** Linda Kastlová *******");
    Console.WriteLine("********** 04.12.2025 *********");
    Console.WriteLine("*******************************");
    Console.WriteLine();

    
    Console.Write("Zadejte přesnost: ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost))
        Console.Write("Nezadali jste číslo. Zadejte číslo znovu: ");

    double i = 1;
    double piCtvrt = 1;
    double znamenko = 1;

    while (1 / i >= presnost)
    {
        i = i + 2;
        znamenko = -znamenko;
        piCtvrt = piCtvrt + znamenko * 1 / i;
    }
    double pi = piCtvrt * 4;
    Console.WriteLine("Zobrazení pí:{0}", pi);
    
    


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}