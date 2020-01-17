using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name");
            var personName = Console.ReadLine();

            Console.WriteLine($"My name is {personName}");


           Console.WriteLine("what is your favorite color?");
           var favoriteColor = Console.ReadLine();

            Console.WriteLine($"My fav color is {favoriteColor}");


            Console.WriteLine("what is your favorite animal");
            var animalName = Console.ReadLine();

            Console.WriteLine($"My favorite animal is {animalName}");


            Console.WriteLine("what is your favorite sport?");
            var sportType = Console.ReadLine();

            Console.WriteLine($"My favorite sport is {sportType}");

            

          Console.WriteLine( Sum(8, 16));
          Console.WriteLine( Sum(5, 7) );

            Console.WriteLine(Mul(10, 2));
            Console.WriteLine(Mul(35, 6));

            Console.WriteLine(Sum(2, 4, 6));

            Add(1, 300);
            Add(3, 900);
            Add(3, 5);
            Add(3.6, 5.6);
            Add(20, 4, true);
           


            
        }
        public static int Sum(int first, int second)
        {
            return first + second;
        }
        public static int Mul(int first, int second)
        {
            return first * second;
        }
        public static int Sum(int first, int second, int third)
        {
            return first + second + third;
        }
        public static void Add(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }
        public static void Add(double firstNum, double secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }
        public static void Add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }
        public static decimal Add(decimal a, decimal b)
        {
            return (a + b);
        }
        public static string Add(int a, int b, bool istrue)
        {
            var answer = a + b;
          if(istrue==true)
            {
                return $"{a + b} dollars";




            }
          else
            {
                return $"{a + b} dollar";
            }
        }
    }

   

       
}
