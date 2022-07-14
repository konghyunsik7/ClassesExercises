using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    internal class Car
    {
        public Car()
        {

        }
        public Car(string carMake, string carModel, int carYear, int carID)
        {
            Make = carMake;
            Model = carModel;
            Year = carYear;
            ItemNum = carID;

        }
        public int ItemNum { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; } = 2022; //return a default value

        public void Print()
        {
            Console.WriteLine($"{Make} | {Model} | {Year} | {ItemNum}");
        }
    }
}
