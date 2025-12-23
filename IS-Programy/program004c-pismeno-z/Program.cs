var again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("**** Vykreslení písmene Z *****");
    Console.WriteLine("*******************************");
    Console.WriteLine("******** Linda Kastlová *******");
    Console.WriteLine("********** 23.12.2025 *********");
    Console.WriteLine("*******************************");
    Console.WriteLine();


    Console.Write("Zadejte šířku písmene (celé číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
        Console.Write("Nezadali jste celé číslo. Zadejte šířku odbélníku znovu: ");

    Console.Write("Zadejte výšku písmene (celé číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
        Console.Write("Nezadali jste celé číslo. Zadejte výšku odbélníku znovu: ");

    for (int row = 0; row < height; row++)
    {
        for (int column = 0; column < width; column++)
        {
            if (row == 0  || row == height - 1) 
            {
                Console.Write("* ");
            }
            else if (column == (width - row - 1))
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }
            
        }
        Console.WriteLine();
    }
   


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}