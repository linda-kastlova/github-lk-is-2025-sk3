var again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("**** Pravoúhlý trojúhelník ****");
    Console.WriteLine("*******************************");
    Console.WriteLine("******** Linda Kastlová *******");
    Console.WriteLine("********** 23.12.2025 *********");
    Console.WriteLine("*******************************");
    Console.WriteLine();

    Console.Write("Zadejte výšku trojúhelníku (celé číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");

    Console.Write("Zadejte šířku trojúhelníku (celé číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");

    for (var row = 0; row < height; row++)
    {
        int stars = (int)Math.Ceiling((row + 1)* (double)width / height);
        
        for (var column = 0; column < width; column++)
        {
            Console.Write(column < stars ? "* " : "  ");
        }
        Console.WriteLine();
    }
    


Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}