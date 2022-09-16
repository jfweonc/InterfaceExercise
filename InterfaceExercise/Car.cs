using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car: IVehicle, ICompany
    {
        public int TruckSize { get; set; }
        public int Travellers { get; set; }
        public bool NumberOfWheels { get; set; }
        public bool CanDrive { get; set; }
        public void Honk()
        {
            Console.WriteLine("honk!"); 
        }
        public void Drive()
        {
            Console.WriteLine($"Hello {TruckSize}"); 
        }
        public string Logo { get; set; }
        public void MakeMoney()
        {
            Console.WriteLine("$$$"); 
        }
    }
}
