using System;

namespace Constructors
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base (registrationNumber: registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
    }
}