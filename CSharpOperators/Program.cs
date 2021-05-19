using System;

namespace CSharpOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Assignment Operator
            int num;
            num = 5;
            Console.WriteLine($"Assigned Value to Variable:{num}");

            //Arithmetic Operators
            int x = 11;
            int y = 3;
            Console.WriteLine($"Addition:{x + y}");
            Console.WriteLine($"Subtration:{x - y}");
            Console.WriteLine($"Multiplication:{x * y}");
            Console.WriteLine($"Division:{x / y}");
            Console.WriteLine($"Modulus :{x % y}");

            x = x + 4;
            Console.WriteLine($"New value of x:{x}");
            Console.WriteLine($"Addition:{x + y}");
            Console.WriteLine($"Subtration:{x - y}");
            Console.WriteLine($"Multiplication:{x * y}");
            Console.WriteLine($"Division:{x / y}");
            Console.WriteLine($"Modulus :{x % y}");

            //Compound Assignment Operators
            x += 5;
            Console.WriteLine(x);
            x -= 3;
            Console.WriteLine(x);
            x *= 2;
            Console.WriteLine(x);
            x /= 3;
            Console.WriteLine(x);
            x %= 3;
            Console.WriteLine(x);


        }
    }
}
