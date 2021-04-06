using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck: ICompany, IVehicle
    {
        public string BedSize { get; set; }
        public int LiftHeight { get; set; }

        public string CompanyName { get; set; }
        public string Region { get; set; }

        public int Wheels { get; set; }
        public string Motor { get; set; }
        public string Drivetrain { get; set; }
        public string Transmission { get; set; }
    }
}
