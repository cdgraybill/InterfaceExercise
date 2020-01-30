using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public bool IsDrivable { get; set; }
        public int TopSpeed { get; set; }
        public int CargoSpace { get; set; }
        public int NumberOfSeats { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
    }
}
