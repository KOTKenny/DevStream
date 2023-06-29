using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Interfaces
{
    public interface IVehicle
    {
        public int MaxSpeed { get; }
        public int WheelsCount { get; }
        public string Model { get; }
        public VehicleColors Color { get; }
    }

    public enum VehicleColors
    {
        Red,
        Green,
        Blue
    }
}
