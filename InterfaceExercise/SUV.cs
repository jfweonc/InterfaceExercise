using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV: IVehicle, ICompany
    {
        public int HoldSize { get; set; }
        public int Passengers { get; set; }
        public bool NumberOfWheels { get; set; }
        public bool CanDrive { get; set; }
        public void Honk()
        {
            Console.WriteLine("honk!");
        }
        public void Drive()
        {
            Console.WriteLine($"Hello {HoldSize}");
        }
        public string Logo { get; set; }
        public void MakeMoney()
        {
            Console.WriteLine("$$$");
        }
    }
}
