using System;
using System.Collections.Generic;

namespace ArrayListAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Array Fixed Size Array
            int[] grades = new int[5];

            //Declare Variable size array
            //int[] grade;

            //Assigned Value to Fixed Array

            // grades[0] = 1;
            //rades[1] = 2;
            //grades[2] = 40;
            //grades[3] = 3;
            // grades[4] = 4;

            //grades = new int[] { 1, 2, 3, 3, 3 };
            Console.WriteLine("Enter Student Grades:");
            for(int i=0;i<5;i++)
            {
                Console.Write("Enter Grade:");
                grades[i] = int.Parse(Console.ReadLine());
            }

           

            //Print value in fixed array 
            Console.WriteLine("The Grades you entered are:");
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(grades[i]);
            }

            //Declare Variable size array
            int[] grade1;
            int grade = 0;
            int index = 0;
            //Assigned Value to Variable array
            grade1 = new int[] { 10, 22, 2, 1, 10, 20, 30, 40, 50, 60, 1 };

            //Print Value in variable array
            Console.WriteLine("The Grades you entered are:");
            for(int i=0;i<grade1.Length;i++)
            {
                Console.WriteLine(grade1[i]);
            }
            //Declare A List
            List<string> names = new List<string>();
            string name = "";
            //Add Value To A List
            names.Add("Nay Kyaw Lin");
            Console.WriteLine("Enterde names:");

            while(!name.Equals("-1"))
            {
                name = Console.ReadLine();
                if(!name.Equals("-1"))
                {
                    names.Add(name);
                }
                
            }

            Console.WriteLine("The Student Name you enterd are(for loop)");
            for(int i=0;i<names.Count;i++)
            {
                Console.WriteLine(names[i]);

            }
            Console.WriteLine("The Student Name you enterd are(foreach loop)");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);

            }
            foreach(string item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
