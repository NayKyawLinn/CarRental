using System;

namespace CondtionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
      int result;
            Console.Write("How many apples do you have?");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many oranges do you have?");
            num2 = Convert.ToInt32(Console.ReadLine());
            //If Statements(<,>,==,<=,>=,!=)
          /*  if(num2<num1)
            {
                Console.WriteLine("You have more apples");
            }
            else if(num2>num1)
            {
                Console.WriteLine("You have more oranges");
            }
            else if(num1==num2)
            {
                Console.WriteLine("You have the same number of apples and oranges");
            }
            else
            {
                Console.WriteLine("Invalid parameter!");

            }
            Console.WriteLine("How many eyes do you have?");
            num3 = Convert.ToInt32(Console.ReadLine());
            //Switch Statements
            switch (num3)
            {
                case 1:
                    Console.WriteLine("Value is 1");
                    break;
                case 2:
                    Console.WriteLine("Valuse is 2");
                    break;
                case 3:
                    Console.WriteLine("Value is 3");
                    break;
                default:
                    Console.WriteLine("Invalid value");
                    break;
            }
*/
            //Tenary Statements
            result = (num1 > num2) ? 1 : 2;
            Console.WriteLine(result);

        }
    }
}
