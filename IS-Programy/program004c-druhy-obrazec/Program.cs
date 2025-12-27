var again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*************************************");
    Console.WriteLine("**** Vykreslení druhého obrazce *****");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** Linda Kastlová **********");
    Console.WriteLine("************* 27.12.2025 ************");
    Console.WriteLine("*************************************");
    Console.WriteLine();


    Console.Write("Zadejte šířku obrazce (celé číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
        Console.Write("Nezadali jste celé číslo. Zadejte šířku obrazce znovu: ");

    Console.Write("Zadejte výšku obrazce (celé číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obrazce znovu: ");

    for (int row = 0; row < height; row++)
    {
        int oddIndex = row / 2;
        bool starOnRight = (oddIndex % 2 == 0);
        
        for (int column = 0; column < width; column++)
        {
            if (row % 2 == 0)
            {
                Console.Write("* ");
            }
            else if ((starOnRight && column == width - 1) || (!starOnRight && column == 0))
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