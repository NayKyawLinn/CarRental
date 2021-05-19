using System;

using System.IO;
namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int n2 = int.Parse(Console.ReadLine());
            try
            {
                int result = n1 / n2;
                Console.WriteLine($"Result:{result}");
            }catch(IOException ex)
                {
              
                Console.WriteLine($"Illegal operation: {ex.Message}");
            }
            finally
            {
              
                Console.WriteLine("End of the program");
            }
        }
    }
}
