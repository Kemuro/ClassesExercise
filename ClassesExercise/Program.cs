using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make ="Audi";
            car1.Model ="R8 Spyder";
            car1.Year = 2021;

            Console.WriteLine($"Make: {car1.Make}");
            Console.WriteLine($"Model: {car1.Model}");
            Console.WriteLine($"Year: {car1.Year}");

        }
    }
}
