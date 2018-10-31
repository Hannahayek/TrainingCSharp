using System;

namespace Constructors_and_Inheritance
{
    public class Car:Vehicle
    { //it will fail if not added paramter:base because the Vehicle class constructor is not without parameter
        //can be fixed as shown with :base
        public Car(string registrtationNumber)
        :base(registrtationNumber) 
                       
        {
            Console.WriteLine("car is being initialized {0}",registrtationNumber);
        }

    }
}