using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;

            var suv1 = new SUV();
            suv1.CargoSpace = "99 sqf.";
            suv1.Drivetrain = "4 Wheel Drive";
            suv1.CompanyName = "Toyota";
            suv1.Motor = "V6";
            suv1.Region = "Japan";
            suv1.TerrainMode = "All Terrain";
            suv1.Transmission = "Automatic";
            suv1.Wheels = 4;

            var truck1 = new Truck();
            truck1.CompanyName = "Chevy";
            truck1.BedSize = "Large";
            truck1.Drivetrain = "4 Wheel Drive";
            truck1.LiftHeight = 6;
            truck1.Transmission = "Automatic";
            truck1.Wheels = 4;
            truck1.Region = "USA";
            truck1.Motor = "V8";

            var car1 = new Car();
            car1.CompanyName = "Dodge";
            car1.Region = "USA";
            car1.Motor = "V8";
            car1.Mode = "Sport";
            car1.Passangers = 5;
            car1.Transmission = "Manual";
            car1.Wheels = 4;
            car1.Drivetrain = "2 Wheel Drive";

            //Creatively display and organize their values

            Console.WriteLine($"The {suv1.CompanyName} 4Runner TRD PRO is powered by a {suv1.Motor} motor. {suv1.CompanyName} is from \n" +
                $"{suv1.Region}. The TRD PRO is a {suv1.Drivetrain} {suv1.TerrainMode} vehicle.");

            Console.WriteLine();

            Console.WriteLine($"{truck1.CompanyName} makes many trucks, if you get one it needs to be a {truck1.Drivetrain} \n" +
                $"{truck1.Motor} powered beast! {truck1.Region}! {truck1.Region}!");

            Console.WriteLine();

            Console.WriteLine($"Why get anything other than the {car1.CompanyName} with the mighty {car1.Motor}!!! \n" +
                $"Such power! Much Wow! {car1.Motor}! {car1.Region}!!!");
        }
    }
}
