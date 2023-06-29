using System;
using Task1.Interfaces;

namespace Task1
{
    public class Car : Vehicle
    {
        public Car() : base(150, 4, "BMW", VehicleColors.Red)
        {

        }

        public Car(int maxSpeed, int wheelsCount, string model, VehicleColors color) : base(maxSpeed, wheelsCount, model, color)
        {

        }
    }
}
