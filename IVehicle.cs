using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {

        public int Wheels { get; set; }
        public string Motor { get; set; }
        public string Drivetrain { get; set; }
        public string Transmission { get; set; }


    }
}
