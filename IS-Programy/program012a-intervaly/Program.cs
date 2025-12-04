
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

            
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int lowerBound;
            while(!int.TryParse(Console.ReadLine(), out lowerBound)) 
            {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int upperBound;
            while(!int.TryParse(Console.ReadLine(), out upperBound)) 
            {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", number, lowerBound, upperBound);
            Console.WriteLine("==========================================");
            Console.WriteLine();

            //deklarace pole    
            int[] myArray = new int[number];

            Random randomNumber = new Random();

            int interval1=0;
            int interval2=0;
            int interval3=0;
            int interval4=0;

            Console.WriteLine("\n\nNáhodná čísla:");
            for(int i=0; i<number; i++) 
            {
                myArray[i] = randomNumber.Next(lowerBound, upperBound+1);
                Console.Write("{0}; ", myArray[i]);

                if(myArray[i]<= (0.25 * upperBound)) 
                {
                    interval1++;
                }
                else if(myArray[i] <= (0.5 * upperBound)) 
                {
                    interval2++;
                }
                else if(myArray[i] <= (0.75 * upperBound)) 
                {
                    interval3++;
                }
                else
                    interval4++; 
           }

            Console.WriteLine("\nInterval <{0}; {1}>: {2}", lowerBound, 0.25 * upperBound, interval1);
            Console.WriteLine("Interval <{0}; {1}>: {2}", 0.25 * upperBound + 1, 0.5 * upperBound, interval2);
            Console.WriteLine("Interval <{0}; {1}>: {2}", 0.5 * upperBound + 1, 0.75 * upperBound, interval3);
            Console.WriteLine("Interval <{0}; {1}>: {2}", 0.75 * upperBound  + 1, upperBound, interval4);

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }