using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car: ICompany, IVehicle
    {
        public string Mode { get; set; }    /* sport, luxury */
        public int Passangers { get; set; }

        public string CompanyName { get; set; }
        public string Region { get; set; }

        public int Wheels { get; set; }
        public string Motor { get; set; }
        public string Drivetrain { get; set; }
        public string Transmission { get; set; }

    }
}
