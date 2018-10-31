using System;

namespace Constructors_and_Inheritance
{
    public class Vehicle
    {
        private readonly string _regiserationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("vheicle is being initializid ");
        //}

        public Vehicle(string regiserationNumber)
        {
            _regiserationNumber = regiserationNumber;
            Console.WriteLine("Vheicle is being initialized and here is {0}",regiserationNumber);

        }
    }
}