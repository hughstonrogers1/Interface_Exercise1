using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : ICompany, IVehicle
    {
        public string TerrainMode { get; set; }
        public string CargoSpace { get; set; }


        public string CompanyName { get; set; }
        public string Region { get; set; }

        public int Wheels { get; set; }
        public string Motor { get; set; }
        public string Drivetrain { get; set; }
        public string Transmission { get; set; }
    }
}
