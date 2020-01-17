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



            
        }
    }
}
