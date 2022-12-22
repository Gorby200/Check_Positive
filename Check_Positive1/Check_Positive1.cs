using System;

namespace Check_Positive1
{
    class Program_Check_Positive1
    {

        static void Main()
        {



            Console.WriteLine("Quantity of entered positive numbers checking program\n");
            Int64 m;
            Int64 CurrentNumber;
            Int64 Counter=0;


            {
                while (true) // Просто проверка введенного значения
                {
                    Console.Write("Enter quantity of numbers: ");
                    if (Int64.TryParse(Console.ReadLine(), out m))
                    {
                        break;
                    }
                    Console.WriteLine("Please enter an int64 value!");
                }

               
                
                for (int i=1; i<=m; i++)
                {
                    while (true) // Просто проверка введенного значения
                    {
                        Console.Write("Enter {0} number: ",i);
                        if (Int64.TryParse(Console.ReadLine(), out CurrentNumber))
                        {
                            break;
                        }
                        Console.WriteLine("Please enter an int64 value!");
                    }
                    if (CurrentNumber > 0) { Counter++; }
                }
                
                Console.WriteLine("Quantity of entered positive numbers = {0}", Counter);


            }
        }
    }
}
