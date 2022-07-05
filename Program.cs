using System;
using System.Collections.Generic;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Modle = "Fusion";
            myCar.Year = 2020;

            var ford = new Car()
            {
                Make = "Ford",
                Modle = "Mustang",
                Year = 2015
            };

            var saab = new Car("Saab", "9.4", 2001);

            var carList = new List<Car>() { myCar, ford, saab };

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Modle} {vehicle.Year}");
            }

        }
    }
}
