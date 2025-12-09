bool debug = false;

string again = "a";
while(again == "a") 
{
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("***************** Intervaly ***************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("************ Linda Kastlová ***************");
            Console.WriteLine("************** 04. 12. 2025 ***************");
            Console.WriteLine();

            
            int totalNumbers;
            int lowerBound;
            int upperBound;
            int intervalCount;
    
            
            if (debug)
            {
                totalNumbers = 10;
                lowerBound = 0;
                upperBound = 10;
                intervalCount = 2;
            }
            else
            {
                Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
                while(!int.TryParse(Console.ReadLine(), out totalNumbers)) {
                    Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
                }   
                
                Console.Write("Zadejte dolní mez (celé číslo): ");
                while(!int.TryParse(Console.ReadLine(), out lowerBound)) 
                {
                    Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
                }

                Console.Write("Zadejte horní mez (celé číslo): ");
                while(!int.TryParse(Console.ReadLine(), out upperBound)) 
                {
                    Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
                }
                
                Console.Write("Zadejte počet intervalů, do kterých se bude základní interval dělit: ");
                while(!int.TryParse(Console.ReadLine(), out intervalCount))
                {
                    Console.Write("Nezadali jste celé číslo. Zadejte počet intervalů znovu: ");
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}; počet intervalů: {3}", totalNumbers, lowerBound, upperBound,  intervalCount);
            Console.WriteLine("==========================================");
            Console.WriteLine();

            // generujeme čísla
            //deklarace pole    
            int[] generatedNumbers = new int[totalNumbers];
            Random randomNumber = new Random();

            for (int i = 0; i < totalNumbers; i++)
            {
                generatedNumbers[i] = randomNumber.Next(lowerBound, upperBound+1);
            }
            
    
            // rozdělujeme do skupinek
            
            int[] intervalFounds = new int[intervalCount];
            int intervalNumbers = (int) Math.Round((double) upperBound / (double) intervalCount);

            for (int number = 0; number < totalNumbers; number++)
            {
                for (int interval = 0; interval < intervalCount; interval++)
                {
                    int inervalStart = (intervalNumbers * interval) + (interval > 0 ? 1 : 0);
                    int inervalEnd = Math.Min(intervalNumbers * (interval + 1), upperBound);

                    if (number >= inervalStart && number <= inervalEnd)
                    {   
                        intervalFounds[interval]++;
                        
                        Console.WriteLine($"Číslo {number} patří do intervalu <{inervalStart}; {inervalEnd}>!");
                    }
                }
            }

            for (int interval = 0; interval < intervalCount; interval++)
            {
                int inervalStart = (intervalNumbers * interval) + (interval > 0 ? 1 : 0);
                int inervalEnd = Math.Min(intervalNumbers * (interval + 1), upperBound);
                
                
                Console.WriteLine($"V intervalu <{inervalStart}; {inervalEnd}> je {intervalFounds[interval]} čísel!");
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }