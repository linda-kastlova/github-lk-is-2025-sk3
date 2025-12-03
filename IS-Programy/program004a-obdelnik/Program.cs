var again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("**** Vykreslení obdélníku *****");
    Console.WriteLine("*******************************");
    Console.WriteLine("******** Linda Kastlová *******");
    Console.WriteLine("********** 23.10.2025 *********");
    Console.WriteLine("*******************************");
    Console.WriteLine();


    Console.Write("Zadejte šířku obdélníku (celé číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
        Console.Write("Nezadali jste celé číslo. Zadejte šířku odbélníku znovu: ");

    Console.Write("Zadejte výšku obdélníku (celé číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
        Console.Write("Nezadali jste celé číslo. Zadejte výšku odbélníku znovu: ");


    for (var i = 1; i <= height; i++)
    {
        for (var j = 1; j <= width; j++)
        {
            Console.Write("* ");
            Thread.Sleep(TimeSpan.FromMilliseconds(100));
        }

        Console.WriteLine();
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}