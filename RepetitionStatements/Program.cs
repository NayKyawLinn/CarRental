using System;

namespace RepetitionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("Enter your name");
            a = Console.ReadLine();
            Console.WriteLine(a);
           //For Loop (Counter Controlled)-Sample printing 5 times
           for(int i=1;i<5;i++)
            {
                Console.WriteLine("I am winner");
                Console.WriteLine($"Count:{i}");
            }
            Console.WriteLine();
            Console.WriteLine("Loop Finished");
            //While Loop(Condition Controlled-Pre Check)
            int n = 0;
    
            while (n<5)
            {

                Console.WriteLine("Input a number(0-4)");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered {n}");
               

            }
            Console.WriteLine();
            Console.WriteLine("while Loop Finished");
            //Do...While(Condition Contolled-Post Check)
            do
            {
                Console.WriteLine("Input a number(0-4)");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered {n}");
            } while (n < 5);
            Console.WriteLine();
            Console.WriteLine("do while Loop Finished");
        }
    }
}
