using System;

namespace StringManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a String variables
            string fullName = "Hi,My name is nay kyaw lin";
            string firstName = "Nay";
            string lastName = "Lin";
            //Print to screen 
            Console.WriteLine(fullName);
            //Concatenation
            Console.WriteLine("My full name is:{0} {1}" ,firstName,lastName);
            Console.WriteLine("My full name is"+firstName+" "+ lastName);
            Console.WriteLine($"My full name is{ firstName} {lastName}");

            //Count length of string
            int length = firstName.Length;
            Console.WriteLine(length);
            int length1 = fullName.Length;
            Console.WriteLine(length1);
            //Replace length of string
            string newName = firstName.Replace('N', 'T');
            Console.WriteLine(newName);
            string newName1 = lastName.Replace('i', ' ');
            Console.WriteLine(newName1);

            
            //Compare Strings
            if(firstName==lastName)
            {
                Console.WriteLine("You have the same name for first and last");
            }
            else
            {
                Console.WriteLine("You have a different name for first and last");
            }
            int result = string.Compare(firstName, lastName);
            if(result==0)
            {

                Console.WriteLine("You have the same name for first and last");
            }
            else
            {
                Console.WriteLine("You have a different name for first and last");
            }

            //Convert To Strings
            result = 1234568;
            string bigNumber = result.ToString();
            Console.WriteLine("My Bank Balance is" + bigNumber);
            int total = 1 + result;
            Console.WriteLine(total);

        }
    }
}
