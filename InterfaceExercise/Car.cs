using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public bool IsDrivable { get; set; }
        public int TopSpeed { get; set; }
        public bool HasTrunk { get; set; }
        public bool HasRadio { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
    }
}