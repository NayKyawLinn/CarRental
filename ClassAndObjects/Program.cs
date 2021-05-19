using System;

namespace ClassAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Variable and datatype declaration
            int num = 0;
            //Create Object of Class Type box
            Box box=new Box();
            Box box2 = new Box();
            Console.WriteLine("Enter Length");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            double n3 = double.Parse(Console.ReadLine());
            //Setting values in object properties
            box.Length = n1;
            box.Breadth = n2;
            box.Height = n3;

            box2.Length = n1;
            box2.Breadth = n2;
            box2.Height = n3;

            double volume = box.getVolume();
            double area = box.getArea();
            //Getting value from object properties
            Console.WriteLine($"Box Dimensions Are:{box.Length},{box.Breadth},{box.Height}");
            Console.WriteLine($"Box Volume Is:{ volume}");
            Console.WriteLine($"Box Area Is:{area}");


            Console.WriteLine($"Box Dimensions Are:{box2.Length},{box2.Breadth},{box2.Height}");
            Console.WriteLine($"Box Volume Is:{box2.getVolume()}");
            Console.WriteLine($"Box Area Is:{box.getArea()}");


            //First Time
            Console.WriteLine("Enter video name Frist Time");

            Video.videoName = Console.ReadLine();
            

            //Second Time
            Console.WriteLine("Enter video name Second");

            Video.videoName = Console.ReadLine();
            Console.WriteLine(Video.videoName);

            //
            Music music1 = new Music();
            Music music2 = new Music();
            Console.WriteLine("Enter music name ");
            music1.musicName= Console.ReadLine();
            Console.WriteLine(music1.musicName);


            Console.WriteLine("Enter music name ");
            music2.musicName = Console.ReadLine();
            Console.WriteLine(music2.musicName);
        }
    }
    

   static class Video
    {
        public static string videoName { get; set; }
       

       
    }
    public class Music
    {
        public  string musicName { get; set; }
    }
}
