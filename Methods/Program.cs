using System;

namespace Methods
{
    class Program
    {
        //Void Functions
        static void PrintName()
        {
            Console.WriteLine("Nay Kyaw Lin");
        }
        static void PrintName(string name)
        {
            Console.WriteLine(name.ToUpper());
        }
        static void PrintNameLowerCase(string name)
        {
            Console.WriteLine(name.ToUpper());
        }
          
        //Value Returning Functions
        static int LargestNumber(int num1,int num2,int num3)
        {
            int largest = num1;
            if(num2>largest)
            {
                largest = num2;
            }
            if(num3>largest)
            {
                largest = num3;

            }
            return largest;
        }

        static void Main(string[] args)
        {

            //Void Function call
            PrintName();
            Console.WriteLine("End Function call");
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            PrintName(name);
            Console.WriteLine("End funtion upper case name");
            PrintNameLowerCase(name);

            //Value Fuction call
            Console.WriteLine("Enter first name");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second name");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third name");
            int n3 = int.Parse(Console.ReadLine());

            int result = LargestNumber(n1, n2, n3);
            Console.WriteLine($"Largest Number:{ result}");


        }
    }
}
