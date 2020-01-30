using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public bool IsDrivable { get; set; }
        public int TopSpeed { get; set; }
        public int BedSpace { get; set; }
        public bool Is4WheelDrive { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
    }
}