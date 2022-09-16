using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck: IVehicle, ICompany
    {
        public double BedSize { get; set; }
        public int Cargo { get; set; }
        public bool NumberOfWheels { get; set; }
        public bool CanDrive { get; set; }
        public void Honk()
        {
            Console.WriteLine("honk!");
        }
        public void Drive()
        {
            Console.WriteLine($"Hello {BedSize}");
        }
        public string Logo { get; set; }
        public void MakeMoney()
        {
            Console.WriteLine("$$$");
        }
    }
}
