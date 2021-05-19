using System;

namespace VariableAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration and Types
            String name;
            int age;
            double salary;
            char gender;
           Boolean working;
            //Prompt Users from input+++
            Console.Write("Enter your name:");
            name = Console.ReadLine();

            Console.Write("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

 

            Console.Write("Enter your Salary:");
            salary = Convert.ToDouble(Console.ReadLine());
          
            Console.Write("Enter your gender(M or F)");
            gender =Convert.ToChar(Console.ReadLine());

            Console.Write("Are you working(True or False)");
            working = Convert.ToBoolean(Console.ReadLine());

            /*//Print to screen
            Console.Write("Your name is:" + name+"Your age is:{0}", age);
            Console.WriteLine("");
            Console.Write("Your age is:{0}" , age);
            Console.Write($"Your salary is: {salary}");
            Console.Write("Your Gender is:" + gender);
            Console.Write("You Are Employed:" + working);*/

            //Home work
            Console.WriteLine(" age : {0} ,name: {1} ,salary:{2} ",age, name, salary);
            Console.WriteLine("Your name is:" + name + "Your age is:{0}", age);




        }
    }
}
