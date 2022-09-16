using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool NumberOfWheels { get; set; }
        public bool CanDrive { get; set; }
        public void Honk();
        public void Drive(); 
    }
}
