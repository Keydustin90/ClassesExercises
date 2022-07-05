using System;
namespace ClassesExercise
{
    public class Car
    {    
        public Car()
        {

        }

        public Car(string make, string modle, int year)
        {
            Make = make;
            Modle = modle;
            Year = year;

        }

        public string Make { get; set; }
        public string Modle { get; set; }
        public int Year { get; set; }
    }
}
