using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    internal class Car: IDrivable, IVehicle
    {
        public void Drive(double km)
        {
            Millage += km;
            CurrentFue1 -= km / 10;
        }
        public double Millage { get; set; }
        public double CurrentFue1 { get; set; }    
    }
}
